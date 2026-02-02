namespace CS_Learning
{
    internal class Demo11Profilers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application started...");

            // Warm-up
            CalculateReport();

            Console.WriteLine("Processing completed.");
            Console.ReadLine();
        }

        static void CalculateReport()
        {
            // CPU-intensive loop
            for (int i = 0; i < 5; i++)
            {
                GenerateLargeString();
                PerformHeavyCalculation();
            }
        }

        static void GenerateLargeString()
        {
            string result = string.Empty;

            // Inefficient string concatenation (CPU hotspot)
            for (int i = 0; i < 50_000; i++)
            {
                result += "DATA";
            }
        }

        static void PerformHeavyCalculation()
        {
            long sum = 0;

            // Artificial CPU-heavy computation
            for (int i = 0; i < 100_000_000; i++)
            {
                sum += i % 7;
            }
        }
    }
}
