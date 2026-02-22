namespace AdvCSConsole
{
    internal class Demo03AsyncReturnTask
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Program Started...");
            var task = DoSomethingAsync();      // non blocking calls
            Console.WriteLine("Could do other things while waiting");

            for (int i = 0; i < 1000000; i++)
            {
                if (task.IsCompleted)
                {
                    Console.WriteLine("***Task Completed here***");
                    break;
                }
                Console.Write(i);
            }

            string value = await task;
            Console.WriteLine(value);
            Console.WriteLine("Program Completed...");
        }

        static async Task<string> DoSomethingAsync()
        {
            Console.WriteLine("Time taking task...");
            await Task.Delay(2000);
            Console.WriteLine("Task Completed...");
            return "***Task Result***";
        }

    }
}
