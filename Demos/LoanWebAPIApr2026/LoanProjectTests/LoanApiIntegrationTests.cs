using LoanWebAPIApr2026;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;

namespace LoanProjectTests
{
    public class LoanApiIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public LoanApiIntegrationTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ApplyLoan_Should_Return_Success()
        {
            var loan = new
            {
                applicantName = "Test2",
                loanAmount = 200000,
                interestRate = 10,
                tenureMonths = 12
            };

            var response = await _client.PostAsJsonAsync("/api/loan", loan);

            response.EnsureSuccessStatusCode();
        }
    }
}
