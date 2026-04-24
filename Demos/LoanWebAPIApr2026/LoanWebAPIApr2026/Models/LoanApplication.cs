namespace LoanWebAPIApr2026.Models
{
    public class LoanApplication
    {
        public int Id { get; set; }
        public string ApplicantName { get; set; }
        public decimal LoanAmount { get; set; }
        public int TenureMonths { get; set; }
        public decimal InterestRate { get; set; }

        // Calculated fields
        public decimal MonthlyPremium { get; set; }
        public decimal TotalPayableAmount { get; set; }

        public DateTime CreatedDate { get; set; }
    }

}
