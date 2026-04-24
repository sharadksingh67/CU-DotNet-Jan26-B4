using LoanWebAPIApr2026.DTOs;

namespace LoanWebAPIApr2026.Services
{
    public interface ILoanService
    {
        Task<LoanResponseDto> CreateLoanAsync(LoanRequestDto request);
        Task<List<LoanResponseDto>> GetAllAsync();
        
    }
}
