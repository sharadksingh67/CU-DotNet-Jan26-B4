namespace AdvCSConsole
{
    internal class ManasaStones
    {
        static void Main(string[] args)
        {
            


            int n = 4; // Total numbers in the series
            int a = 10; // First difference
            int b = 100; // Second difference

            //int totalJumps = n - 1; // 3 jumps to get 4 numbers

            //SortedSet<int> finalValues = new SortedSet<int>();


            //for (int i = 0; i <= totalJumps; i++)
            //{
            //    int result = (i * b) + ((totalJumps - i) * a);
            //    finalValues.Add(result);
            //}

            //List<int> list = finalValues.ToList();

            //Console.WriteLine(string.Join(", ", finalValues));



            int totalJumps = n - 1; // 3 jumps to get 4 numbers

            //SortedSet<int> finalValues = new SortedSet<int>();

            //for (int i = 0; i <= totalJumps; i++)
            //{
            //    int result = (i * b) + ((totalJumps - i) * a);
            //    finalValues.Add(result);
            //}

            //List<int> list = finalValues.ToList();
            ////return list;
                    




            //int totalJumps = n - 1; // 3 jumps to get 4 numbers
            List<int> list = new List<int>();

            for (int i = 0; i <= totalJumps; i++)
            {
                int result = (i * b) + ((totalJumps - i) * a);
                list.Add(result);
            }

            list.Sort();
            //return list;

            Console.WriteLine("done");






            //// Loop for the 1st position
            //foreach (int i in options)
            //{
            //    // Loop for the 2nd position
            //    foreach (int j in options)
            //    {
            //        // Loop for the 3rd position
            //        foreach (int k in options)
            //        {
            //            Console.WriteLine($"{i}, {j}, {k}");
            //        }
            //    }
            //}
        }
    }
}
