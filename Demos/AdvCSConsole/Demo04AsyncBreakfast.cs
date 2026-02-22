using System.Diagnostics;

namespace AdvCSConsole
{
    internal class Demo04AsyncBreakfast
    {
        static async Task Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine("Preparing Breakfast... ");
            var toast = MakeToastAsync();
            var coffee = MakeCoffeeAsync();
            var omlette = MakeOmletteAsync();

            Console.WriteLine("Utilizing waiting time");
            Console.WriteLine("Taking some short calls");
            Console.WriteLine("Making my breakfast table ready");

            string[] breakfast = await Task.WhenAll(toast, coffee, omlette);

            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            foreach (string item in breakfast)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Completed All Tasks, Breakfast Done");
        }

        static async Task<string> MakeToastAsync()
        {
            await Task.Delay(3000);
            return "Toast Ready...";
        }

        static async Task<string> MakeCoffeeAsync()
        {
            await Task.Delay(2000);
            return "Coffee Ready...";
        }
        static async Task<string> MakeOmletteAsync()
        {
            await Task.Delay(4000);
            return "Omlette Ready...";
        }
    }

}
