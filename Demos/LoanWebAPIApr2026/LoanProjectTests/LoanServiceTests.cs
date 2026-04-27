using AutoMapper;
using LoanWebAPIApr2026.DTOs;
using LoanWebAPIApr2026.Models;
using LoanWebAPIApr2026.Repositories;
using LoanWebAPIApr2026.Services;
using Microsoft.Extensions.Logging;
using Moq;

namespace LoanProjectTests
{
    public class LoanServiceTests
    {
        private readonly Mock<ILoanRepository> _repoMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<ILogger<LoanService>> _loggerMock;

        private readonly LoanService _service;

        public LoanServiceTests()
        {
            _repoMock = new Mock<ILoanRepository>();
            _mapperMock = new Mock<IMapper>();
            _loggerMock = new Mock<ILogger<LoanService>>();

            _service = new LoanService(
                _repoMock.Object,
                _mapperMock.Object,
                _loggerMock.Object);
        }

        [Fact]
        public async Task ApplyLoanAsync_Should_Calculate_EMI_And_Save()
        {
            // Arrange
            var request = new LoanRequestDto
            {
                ApplicantName = "Sharad",
                LoanAmount = 100000,
                InterestRate = 12,
                TenureMonths = 12
            };

            var entity = new LoanApplication();

            _mapperMock.Setup(m => m.Map<LoanApplication>(request))
                       .Returns(entity);

            _repoMock.Setup(r => r.AddAsync(It.IsAny<LoanApplication>()))
                     .ReturnsAsync(entity);

            _mapperMock.Setup(m => m.Map<LoanResponseDto>(It.IsAny<LoanApplication>()))
                       .Returns(new LoanResponseDto());

            // Act
            var result = await _service.CreateLoanAsync(request);

            // Assert
            Assert.NotNull(result);

            _repoMock.Verify(r => r.AddAsync(It.IsAny<LoanApplication>()), Times.Once);

            // EMI indirectly verified
            Assert.True(entity.MonthlyPremium == 8884.88m);
            Assert.True(entity.TotalPayableAmount == 106618.56m);

        }

        [Theory]
        [InlineData(200000, 10, 24, 9228.90, 221496)]
        [InlineData(500000, 8, 36, 15668.34, 564055)]
        public async Task CreateLoanAsync_Should_Calculate_Correct_EMI_And_Total(
                                            decimal loanAmount,
                                            decimal interestRate,
                                            int tenureMonths,
                                            decimal expectedEmi,
                                            decimal expectedTotal)
        {
            // Arrange
            var request = new LoanRequestDto
            {
                ApplicantName = "Test User",
                LoanAmount = loanAmount,
                InterestRate = interestRate,
                TenureMonths = tenureMonths
            };

            var entity = new LoanApplication();

            _mapperMock.Setup(m => m.Map<LoanApplication>(request))
                       .Returns(entity);

            _repoMock.Setup(r => r.AddAsync(It.IsAny<LoanApplication>()))
                     .ReturnsAsync(entity);

            _mapperMock.Setup(m => m.Map<LoanResponseDto>(It.IsAny<LoanApplication>()))
                       .Returns(new LoanResponseDto());

            // Act
            var result = await _service.CreateLoanAsync(request);

            // Assert
            Assert.NotNull(result);

            Assert.InRange(entity.MonthlyPremium, expectedEmi - 1, expectedEmi + 1);
            Assert.InRange(entity.TotalPayableAmount, expectedTotal - 1, expectedTotal + 1);

            _repoMock.Verify(r => r.AddAsync(It.IsAny<LoanApplication>()), Times.Once);
        }


        [Theory]
        [InlineData(100000, 5, 6)]
        [InlineData(100000, 20, 60)]
        [InlineData(50000, 7.5, 12)]
        public async Task CreateLoanAsync_Should_Work_For_Boundary_Values(
                        decimal loanAmount,
                        decimal interestRate,
                        int tenureMonths)
        {
            var request = new LoanRequestDto
            {
                ApplicantName = "Boundary User",
                LoanAmount = loanAmount,
                InterestRate = interestRate,
                TenureMonths = tenureMonths
            };

            var entity = new LoanApplication();

            _mapperMock.Setup(m => m.Map<LoanApplication>(request))
                       .Returns(entity);

            _repoMock.Setup(r => r.AddAsync(It.IsAny<LoanApplication>()))
                     .ReturnsAsync(entity);

            _mapperMock.Setup(m => m.Map<LoanResponseDto>(It.IsAny<LoanApplication>()))
                       .Returns(new LoanResponseDto());

            var result = await _service.CreateLoanAsync(request);

            Assert.True(entity.MonthlyPremium > 0);
            Assert.True(entity.TotalPayableAmount > entity.LoanAmount);
        }


        [Theory]
        [InlineData(100000, 0, 12)]   // invalid rate
        [InlineData(100000, 10, 0)]   // invalid tenure
        [InlineData(100000, -5, 12)]  // negative rate
        public async Task CreateLoanAsync_Should_Throw_For_Invalid_Inputs(
                    decimal loanAmount,
                    decimal interestRate,
                    int tenureMonths)
        {
            var request = new LoanRequestDto
            {
                LoanAmount = loanAmount,
                InterestRate = interestRate,
                TenureMonths = tenureMonths
            };

            await Assert.ThrowsAsync<ArgumentException>(
                () => _service.CreateLoanAsync(request));
        }
    }
}