namespace OOPSLearning
{
    internal class Demo14ArrayRandom
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]
            {
                { 1, 2, 3, 4 },
                { 2, 3, 4, 5 },
                { 5, 6, 7, 8 }
            };

            bool found = false;

            Console.WriteLine();
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(r.Next(1,26));
            }
        }
    }
}