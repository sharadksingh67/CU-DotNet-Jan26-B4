using Serilog;

namespace CS_Learning
{
    internal class Demo09Serilog
    {
        static void Main(string[] args)
        {
            // 1. Configure Serilog
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .WriteTo.File(
                    path: @"../../../logs/app.log",
                    rollingInterval: RollingInterval.Day)
                .CreateLogger();

            try
            {
                Log.Information("Application started");

                int premium = 10000;
                Log.Information("Premium entered: {Premium}", premium);

                if (premium > 5000)
                {
                    Log.Warning("High premium detected");
                }

                int discount = CalculateDiscount(premium);
                Log.Information("Discount calculated: {Discount}", discount);

                Log.Information("Application ended");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Unhandled exception occurred");
            }
            finally
            {
                // 2. Ensure logs are flushed
                Log.CloseAndFlush();
            }
        }

        static int CalculateDiscount(int premium)
        {
            return premium / 10;
        }
    }
    }

