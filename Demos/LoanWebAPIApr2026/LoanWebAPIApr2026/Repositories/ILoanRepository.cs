using LoanWebAPIApr2026.Models;

namespace LoanWebAPIApr2026.Repositories
{
    public interface ILoanRepository
    {
        Task<LoanApplication> AddAsync(LoanApplication loan);
        Task<List<LoanApplication>> GetAllAsync();
        Task<bool> HasActiveLoanAsync(string applicantName);
    }
}
