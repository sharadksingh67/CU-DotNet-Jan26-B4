using System.Diagnostics;

namespace Week6Learnings
{
    internal class Demo01Tracing
    {
        static int GetSum(params int[] arr)
        {
            if (arr.Length == 0)
            {
                Trace.TraceInformation("No value Passed");
                Trace.TraceWarning("No value Passed");
                Trace.TraceError("No value Passed");
            }
            else
                Trace.TraceInformation($"{arr.Length} numbers passed");
                int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static void Show()
        {
            Trace.WriteLine("Show Method Called");
            Console.WriteLine("Show Method Called");
        }
        static void Display()
        {
            Trace.WriteLine("Display Method Called");
            Console.WriteLine("Display Method Called");
        }
        static void Main(string[] args)
        {
            string traceFile = @"../../../trace.log";

            var listner  = new TextWriterTraceListener(traceFile);
            Trace.Listeners.Add(listner);
            Trace.AutoFlush = true;

            Trace.WriteLine(DateTime.Now);

            Trace.WriteLine("Main Started...");

            int[] arr = { 4,5,6,7};
            int result = GetSum(arr);

            int result2 = GetSum(4,5,6,7,7,8,9,9,5,6,7);
            Console.WriteLine(result2);

            int result3 = GetSum();
            Console.WriteLine(result3);

            Trace.Listeners.Remove(listner);

            Show();
            Display();            

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine( i );
            }

            Trace.WriteLine("Main completed...");
        }
    }
}





