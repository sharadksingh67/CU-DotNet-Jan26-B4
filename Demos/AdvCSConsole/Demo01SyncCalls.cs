namespace AdvCSConsole
{
    internal class Demo01SyncCalls
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Started...");
            DoSomethingSync();      // blocking calls
            Console.WriteLine("Could do other things while waiting");
            Console.WriteLine("Program Completed...");
        }

        static void DoSomethingSync()
        {
            Console.WriteLine("Time taking task...");
            Thread.Sleep(20000);
            // Task.Delay(2000);
        }
    }
}
