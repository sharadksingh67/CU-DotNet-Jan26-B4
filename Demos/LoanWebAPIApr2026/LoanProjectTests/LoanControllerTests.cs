using LoanWebAPIApr2026.Common;
using LoanWebAPIApr2026.Controllers;
using LoanWebAPIApr2026.DTOs;
using LoanWebAPIApr2026.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace LoanProjectTests
{
    public class LoanControllerTests
    {
        private readonly Mock<ILoanService> _serviceMock;
        private readonly LoanController _controller;

        public LoanControllerTests()
        {
            _serviceMock = new Mock<ILoanService>();
            _controller = new LoanController(_serviceMock.Object);
        }

        [Fact]
        public async Task Create_Should_Return_Ok_With_ApiResponse()
        {
            // Arrange
            var request = new LoanRequestDto
            {
                ApplicantName = "Sharad",
                LoanAmount = 100000,
                InterestRate = 12,
                TenureMonths = 12
            };

            var serviceResponse = new LoanResponseDto
            {
                MonthlyPremium = 8884.88m,
                TotalPayableAmount = 106618.56m
            };

            _serviceMock.Setup(s => s.CreateLoanAsync(request))
                        .ReturnsAsync(serviceResponse);

            // Act
            var result = await _controller.Create(request);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);

            var apiResponse = Assert.IsType<ApiResponse<LoanResponseDto>>(okResult.Value);

            Assert.True(apiResponse.Success);
            Assert.Equal("Loan Created", apiResponse.Message);
            Assert.NotNull(apiResponse.Data);

            Assert.Equal(8884.88m, apiResponse.Data.MonthlyPremium);
            Assert.Equal(106618.56m, apiResponse.Data.TotalPayableAmount);
        }

        [Theory]
        [InlineData(100000, 12, 12)]
        [InlineData(200000, 10, 24)]
        [InlineData(50000, 8, 6)]
        public async Task Create_Should_Work_For_Multiple_Inputs(
                        decimal loanAmount,
                        decimal interestRate,
                        int tenure)
        {
            var request = new LoanRequestDto
            {
                LoanAmount = loanAmount,
                InterestRate = interestRate,
                TenureMonths = tenure
            };

            _serviceMock.Setup(s => s.CreateLoanAsync(It.IsAny<LoanRequestDto>()))
                        .ReturnsAsync(new LoanResponseDto());

            var result = await _controller.Create(request);

            var okResult = Assert.IsType<OkObjectResult>(result);

            Assert.NotNull(okResult.Value);
        }

        [Fact]
        public async Task Create_Should_Throw_When_Service_Fails()
        {
            var request = new LoanRequestDto();

            _serviceMock.Setup(s => s.CreateLoanAsync(It.IsAny<LoanRequestDto>()))
                        .ThrowsAsync(new Exception("Something went wrong"));

            await Assert.ThrowsAsync<Exception>(() => _controller.Create(request));
        }
    }
}
