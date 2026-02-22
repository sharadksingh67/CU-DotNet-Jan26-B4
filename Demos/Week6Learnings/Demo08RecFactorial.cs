namespace Week6Learnings
{
    internal class Demo08RecFactorial
    {
        //static int Factorial(int n)
        //{
        //    // 1. Base Case: If n is 1, we stop and return 1
        //    if (n <= 1)
        //    {
        //        return 1;
        //    }

        //    // 2. Recursive Step: n * Factorial of (n - 1)
        //    return n * Factorial(n - 1);
        //}
        static int Factorial(int n, string indent = "")
        {
            // Print the entrance
            Console.WriteLine($"{indent}Entering Factorial({n})");

            if (n <= 1)
            {
                Console.WriteLine($"{indent}Base Case reached! Returning 1");
                return 1;
            }

            // Recursive Call
            // We add more spaces to the indent for the next level
            int result = n * Factorial(n - 1, indent + "  ");

            // Print the exit/result
            Console.WriteLine($"{indent}Factorial({n}) calculated: {n} * {result / n} = {result}");

            return result;
        }
        static void Main(string[] args)
        {
            var fact = Factorial(5);
            Console.WriteLine(fact);
        }
    }
}
