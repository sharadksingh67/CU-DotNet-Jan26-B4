using LoanWebAPIApr2026.Data;
using LoanWebAPIApr2026.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanWebAPIApr2026.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly AppDbContext _context;

        public LoanRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> HasActiveLoanAsync(string applicantName)
        {
            return await _context.Loans
                .AnyAsync(l => l.ApplicantName == applicantName);
        }

        public async Task<LoanApplication> AddAsync(LoanApplication loan)
        {
            await _context.Loans.AddAsync(loan);
            await _context.SaveChangesAsync();
            return loan;
        }

        public async Task<List<LoanApplication>> GetAllAsync()
        {
            return await _context.Loans.ToListAsync();
        }
    }

}
