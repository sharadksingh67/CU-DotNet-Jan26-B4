using Microsoft.Extensions.Logging;

namespace CS_Learning
{
    internal class Demo09Logger
    {
        static void Main(string[] args)
        {
            // 1. Create Logger Factory
            using ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddConsole()
                    .SetMinimumLevel(LogLevel.Information);
            });

            // 2. Create Logger
            ILogger logger = loggerFactory.CreateLogger<Demo09Logger>();

            // 3. Use Logger
            logger.LogInformation("Application started");

            int premium = 10000;
            logger.LogInformation("Premium entered: {Premium}", premium);

            if (premium > 5000)
            {
                logger.LogWarning("High premium detected");
            }

            try
            {
                int discount = CalculateDiscount(premium);
                logger.LogInformation("Discount calculated: {Discount}", discount);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error during discount calculation");
            }

            logger.LogInformation("Application ended");
        }

        static int CalculateDiscount(int premium)
        {
            return premium / 10;
        }
    }
}

