using FluentValidation;
using LoanWebAPIApr2026.DTOs;

namespace LoanWebAPIApr2026.Validators
{
    public class LoanRequestValidator : AbstractValidator<LoanRequestDto>
    {
        public LoanRequestValidator()
        {
            RuleFor(x => x.ApplicantName).NotEmpty();

            RuleFor(x => x.LoanAmount)
                .GreaterThan(100000);

            RuleFor(x => x.LoanAmount)
                .LessThan(10000000);

            RuleFor(x => x.TenureMonths)
                .InclusiveBetween(6, 360);

            RuleFor(x => x.InterestRate)
                .InclusiveBetween(5, 20);
        }
    }
}
