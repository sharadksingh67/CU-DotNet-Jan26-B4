namespace CS_Learning
{
    internal class Demo03DateTime
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            Console.WriteLine($"{today:dd/MM/yyyy}");
            Console.WriteLine($"{today:dd/MMM/yyyy}");
            Console.WriteLine($"{today:dd/MMMM/yyyy}");

            DateTime now = DateTime.Now;
            Console.WriteLine(now);
        }
    }
}
