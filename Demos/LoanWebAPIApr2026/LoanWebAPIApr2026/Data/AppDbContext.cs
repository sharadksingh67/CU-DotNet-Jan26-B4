using LoanWebAPIApr2026.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanWebAPIApr2026.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<LoanApplication> Loans { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new LoanConfig().Configure(modelBuilder.Entity<LoanApplication>());
        }
    }
}
