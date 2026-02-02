namespace OOPSLearning
{
    internal class BetweenSets
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4 };
            int[] b = { 16, 32, 96 };

            List<int> c = new List<int>();

            List<int> result = new List<int>();
            int[] d = new int[10];
            int i = 1;
            int start = a[a.Length - 1];
            int next = start;
            while (next <= b[0])
            {
                c.Add(next);
                next = start * (++i);
            }
            // Console.WriteLine(string.Join(",", c));

            foreach (var item in c)
            {
                bool allDivide = true;
                foreach (var elem in b)
                {
                    if (elem % item != 0) allDivide=false;
                }
                if (allDivide) result.Add(item);
            }
            // Console.WriteLine(string.Join(",", result));

            
        }
    }
}
