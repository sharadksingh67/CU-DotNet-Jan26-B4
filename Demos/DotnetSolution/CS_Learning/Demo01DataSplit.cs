namespace CS_Learning
{
    internal class Demo01DataSplit
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Demo1 DataTypes");
            //int age = 20;
            //for (int i = 1; i <= age; i = i + 2)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Enter Name Age and City (seperate by ,)");
            //string input = Console.ReadLine(); // "Sharad Singh,22,CHD"
            //string[] inputs = input.Split(',');
            //string name = inputs[0];
            //int age = int.Parse(inputs[1]);
            //string city = inputs[2];
            //Console.WriteLine($"Name = {name}, Age = {age} City = {city}");


            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write($"{i} {6-i} ");
            //}
            //Console.WriteLine();

            //int[] marks = new int[5];
            //string[] fruits = new string[10];
            //fruits[0] = "Orange";
            //fruits[9] = "Papaya";
            //string[] cities = { "Delhi", "Ludhiana", "CHD", "Noida" };


            //string cityNames = "\"Delhi\", \"Ludhiana\", \"CHD\", \"Noida\"";


            //string cityNames = "Delhi, Ludhiana, CHD, Noida";
            //Console.WriteLine(cityNames);
            //string[] cities = cityNames.Split(',');
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //string cityNames = "Delhi, Ludhiana, CHD, Noida";
            //Console.WriteLine(cityNames);
            //string[] cities = cityNames.Split(", ");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //string cityNames = "Delhi, ,Ludhiana, ,CHD, ,Noida";
            //Console.WriteLine(cityNames);
            //string[] cities = cityNames.Split(',');
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    if(cities[i] != " ")
            //        Console.WriteLine(cities[i]);
            //}

            string cityNames = "Delhi,,Ludhiana, ,CHD,   ,Noida";
            Console.WriteLine(cityNames);

            string[] cities = cityNames.Split(',',
                StringSplitOptions.RemoveEmptyEntries
                | StringSplitOptions.TrimEntries);

            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }


            //string cityNames = "Delhi,Ludhiana;CHD Noida";
            //Console.WriteLine(cityNames);
            //// create an array of separators characters
            //char[] separators = { ',', ';',' '};
            //string[] cities = cityNames.Split(separators);
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int x = 100;
            //uint y = 3265325672;

            for (int row = 0; row < 5; row++)
            {
                for (int spaces = 0; spaces < 5 - row - 1; spaces++)
                {
                    Console.Write($" ");
                }

                for (int col = 0; col <= row; col++)
                {
                    Console.Write($"{(char)('A' + col)}");
                }
                Console.WriteLine();
            }
        }
    }
}
