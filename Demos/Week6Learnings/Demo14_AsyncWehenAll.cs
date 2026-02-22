using System.Diagnostics;

namespace Week6Learnings
{
    internal class Demo14_AsyncWehenAll
    {
        static async Task Main()
        {
            var stopwatch = Stopwatch.StartNew();
            Console.WriteLine("Cooking started...");

            // 1. Start all tasks simultaneously (do NOT 'await' them yet)
            Task<string> toastTask = ToastBreadAsync();
            Task<string> eggTask = FryEggsAsync();
            Task<string> coffeeTask = PourCoffeeAsync();

            Console.WriteLine("Mean time arranging table...");
            Console.WriteLine("Mean time arranging cutlery...");
            Console.WriteLine("Mean time taking a short call...");

            // 2. Wait for all of them to complete
            // This returns an array of results: string[]
            string[] results = await Task.WhenAll(toastTask, eggTask, coffeeTask);

            stopwatch.Stop();

            Console.WriteLine("\n--- Breakfast Ready ---");
            foreach (var item in results)
            {
                Console.WriteLine($"- {item}");
            }

            Console.WriteLine($"\nTotal time elapsed: {stopwatch.ElapsedMilliseconds}ms");
        }

        static async Task<string> ToastBreadAsync()
        {
            await Task.Delay(3000); // Simulating 3 seconds
            return "Toast is crispy";
        }

        static async Task<string> FryEggsAsync()
        {
            await Task.Delay(2000); // Simulating 2 seconds
            return "Eggs are sunny-side up";
        }

        static async Task<string> PourCoffeeAsync()
        {
            await Task.Delay(500); // Simulating 0.5 seconds
            return "Coffee is hot";
        }
    }
}
