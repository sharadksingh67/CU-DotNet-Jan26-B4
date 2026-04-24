namespace LoanWebAPIApr2026.DTOs
{
    public class LoanResponseDto
    {
        public int Id { get; set; }
        public string ApplicantName { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal MonthlyPremium { get; set; }
        public decimal TotalPayableAmount { get; set; }
    }
}
