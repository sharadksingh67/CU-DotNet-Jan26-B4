namespace Week6Learnings
{
    internal class Demo12AsyncAwait
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Calling API...");
            var name = GetNamefromAPI();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Till I get name, doing some other work");
            }

            string result = await name;

            Console.WriteLine(result);            
        }

        static async Task<string> GetNamefromAPI()
        {
            Console.WriteLine("Fetching API...may take some time");

            await Task.Delay(3000);

            return "Sharad";
        }
    }
}
