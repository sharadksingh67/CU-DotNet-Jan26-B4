using LoanWebAPIApr2026.Data;
using LoanWebAPIApr2026.Models;
using LoanWebAPIApr2026.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LoanProjectTests
{
    public class LoanRepositoryTests
    {
        private AppDbContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            return new AppDbContext(options);
        }

        [Fact]
        public async Task AddAsync_Should_Add_Record()
        {
            var context = GetDbContext();
            var repo = new LoanRepository(context);

            var loan = new LoanApplication { ApplicantName = "Test", LoanAmount = 1000 };

            var result = await repo.AddAsync(loan);

            Assert.Equal(1, context.Loans.Count());
        }
    }
}
