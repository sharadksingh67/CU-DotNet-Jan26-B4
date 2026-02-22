namespace Week6Learnings
{
    internal class Demo10ThreadsIntro
    {
        static void Display1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"**{i}");
                // Thread.Sleep(100);
            }
            Console.WriteLine();
        }
        static void Display2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"$${i}");
                // Thread.Sleep(100);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Display1);
            Thread t2 = new Thread(Display2);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();


            //Display1();
            //Display2();
        }
    }
}
