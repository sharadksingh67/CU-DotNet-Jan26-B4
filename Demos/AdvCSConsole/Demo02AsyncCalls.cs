namespace AdvCSConsole
{
    internal class Demo02AsyncCalls
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Program Started...");
            var result =  DoSomethingAsync();      // non blocking calls
            Console.WriteLine("Could do other things while waiting");
            for (int i = 0; i < 1000000; i++)
            {
                Console.Write(i);
            }
            await result;
            Console.WriteLine("Program Completed...");
        }

        static async Task DoSomethingAsync()
        {
            Console.WriteLine("Time taking task...");
            await Task.Delay(2000);
            Console.WriteLine("Task Completed...");
        }

    }
}
