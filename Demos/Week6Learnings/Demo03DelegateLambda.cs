namespace Week6Learnings
{
    delegate void MyDelegate();
    internal class Demo03DelegateLambda
    {
        static void MyMethod1()
        {
            Console.WriteLine("MyMethod1");
        }
        static void MyMethod2()
        {
            Console.WriteLine("MyMethod2");
        }
        static void Main(string[] args)
        {

            MyDelegate del1 = delegate ()
            {
                Console.WriteLine("Anonymous method referred...");
            };
            del1();
            MyDelegate del2 = () => Console.WriteLine("Lambda Working");

            Action act1 = () => Console.WriteLine("Action Working...");

            Action<int> act2 = (x) =>
                    Console.WriteLine("Action Working - " + x);

            act2(10);

            Action<int, string> act3 = (num, name)
                => Console.WriteLine($"Action Working - {num} {name}");

            act3(20, "abc");

            Action<int, string> act4 = (num, name)
                =>
            {
                Console.WriteLine($"Action Working - {num} ");
                Console.WriteLine($"Action Working - {name}");
            };

            act4(40, "xyz");

            Func<int, int> GetDouble = (x) => x * 2;

            int result1 = GetDouble(10);
            Console.WriteLine(result1);

            Func<int, int, int> GetSum = (x, y) => x + y;




        }
    }
}
