using LoanWebAPIApr2026.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoanWebAPIApr2026.Data
{
    public class LoanConfig : IEntityTypeConfiguration<LoanApplication>
    {
        public void Configure(EntityTypeBuilder<LoanApplication> builder)
        {
            builder.ToTable("LoanApplications");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ApplicantName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.LoanAmount)
                   .HasPrecision(18, 2);

            builder.Property(x => x.InterestRate)
                   .HasPrecision(5, 2);
        }
    }

}
