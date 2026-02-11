using System;

namespace Week6Learnings
{
    internal class Demo04LINQ
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int> {
                    12,13,45,46,67,68,58,59
            };

            Console.WriteLine(values.Count());

            var aboveFifty = values.Where(x => x > 50)
                                    .OrderByDescending(x => x);

            Console.WriteLine(string.Join(",", aboveFifty));

            List<int> aboveFiftyList =
                values.Where(x => x > 50).ToList();

            Console.WriteLine(string.Join(",", aboveFiftyList));
        }
    }
}
