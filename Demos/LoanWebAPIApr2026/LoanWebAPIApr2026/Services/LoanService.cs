using AutoMapper;
using LoanWebAPIApr2026.DTOs;
using LoanWebAPIApr2026.Exceptions;
using LoanWebAPIApr2026.Models;
using LoanWebAPIApr2026.Repositories;

namespace LoanWebAPIApr2026.Services
{
    public class LoanService : ILoanService
    {
        private readonly ILoanRepository _repo;
        private readonly IMapper _mapper;
        private readonly ILogger<LoanService> _logger;

        public LoanService(ILoanRepository repo, IMapper mapper, ILogger<LoanService> logger)
        {
            _repo = repo;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<LoanResponseDto> CreateLoanAsync(LoanRequestDto dto)
        {
            // NO DTO input validations here

            // Automatically handled as per RULES defined in FluentValidation

            // Business Rule Validation
            // ✅ NEW Business Rule: Only one active loan per applicant
            var hasLoan = await _repo.HasActiveLoanAsync(dto.ApplicantName);

            if (hasLoan)
            {
                throw new BusinessException("Applicant already has an active loan.");
            }

            var loan = _mapper.Map<LoanApplication>(dto);

            // EMI Calculation
            var monthlyRate = dto.InterestRate / 12 / 100;
            var n = dto.TenureMonths;

            loan.MonthlyPremium = CalculateEmi(dto.LoanAmount, dto.InterestRate, dto.TenureMonths);
            loan.TotalPayableAmount = loan.MonthlyPremium * dto.TenureMonths;

            loan.CreatedDate = DateTime.UtcNow;

            _logger.LogInformation("Before DB call");

            var result = await _repo.AddAsync(loan);

            return _mapper.Map<LoanResponseDto>(result);
        }

        public async Task<List<LoanResponseDto>> GetAllAsync()
        {
            var data = await _repo.GetAllAsync();
            return _mapper.Map<List<LoanResponseDto>>(data);
        }

        private decimal CalculateEmi(decimal principal, decimal annualRate, int tenureMonths)
        {
            if (tenureMonths <= 0)
                throw new ArgumentException("Tenure must be greater than zero.");

            if (annualRate <= 0)
                throw new ArgumentException("Interest rate must be greater than zero.");

            // Convert to monthly rate (double for Math.Pow)
            double monthlyRate = (double)(annualRate / 12 / 100);
            int n = tenureMonths;

            double emi = (double)principal * monthlyRate * Math.Pow(1 + monthlyRate, n) /
                         (Math.Pow(1 + monthlyRate, n) - 1);

            return Math.Round((decimal)emi, 2);
        }
    }

}
