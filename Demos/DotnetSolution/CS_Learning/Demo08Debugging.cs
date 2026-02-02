using System.Diagnostics;

namespace CS_Learning
{
    internal class Demo08Debugging
    {
        static void Main(string[] args)
        {
            

            Console.Write("Enter policy holder age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter annual premium: ");
            decimal premium = Convert.ToDecimal(Console.ReadLine());

#if DEBUG
            Console.WriteLine("DEBUG mode is ON");
            Debug.WriteLine("This runs only in Debug build");
#endif



            Trace.WriteLine("Input done...");

            Trace.Listeners.Add(
                    new TextWriterTraceListener(@"..\..\trace.log"));

            Trace.AutoFlush = true;

            Trace.TraceInformation("Processing started");
            Trace.TraceWarning("Premium is unusually high");
            Trace.TraceError("Calculation failed");

            Trace.WriteLine("Input done...");

            Console.WriteLine("Starting Step Demo");


            decimal discount = CalculateDiscount(age, premium);

            decimal finalAmount = premium - discount;

            Console.WriteLine($"Final Premium Amount: {finalAmount}");

            Trace.WriteLine("Output done...");

            
        }

        static decimal CalculateDiscount(int age, decimal premium)
        {
            decimal discount;

            if (age >= 60)
            {
                discount = premium * 0.20m;
            }
            else
            {
                discount = premium * 0.10m;
            }

            return discount;
        }
    }
}
