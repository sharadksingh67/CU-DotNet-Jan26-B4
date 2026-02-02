namespace CS_Learning
{
    internal class Demo06Methods
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Starting Demo");
            //SayHello();
            ////Console.WriteLine("Calling Method Again");
            //SayHello("Sharad");

            ////DemoMethods obj = new DemoMethods();
            ////obj.CallAnotherClassMethod();

            //DemoMethods.CallAnotherClassMethod();

            //int square = GetSquare(10);
            //Console.WriteLine($"Square of {10} is {square}");

            //int[] result = GetOddNumbers(11);
            //Console.WriteLine(string.Join(",",result));

            //int x = 10;
            //Console.WriteLine($"x={x}");
            //ChangeValue(ref x);
            //Console.WriteLine($"x={x}");

            //string[] names = new string[5]; // { "s1", "s2", "s3", "s4", "s5" };
            //int[] marks = new int[5]; // { 77, 88, 66, 55, 99 };

            //#region validate
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        bool validate = true;
            //        do
            //        {
            //            Console.Write($"{i+1} : Enter Name and score - ");
            //            string entry = Console.ReadLine();
            //            string[] entries = entry.Split();
            //            string name = entries[0];
            //            int score = int.Parse(entries[1]);
            //            if (score < 0 || score > 100)
            //            {
            //                validate = false;
            //            }
            //            else
            //            {
            //                names[i] = name;
            //                marks[i] = score;
            //                validate = true;
            //             }

            //        }
            //        while (!validate);
            //    }
            //}
            //#endregion

            //string topper = GetNameOfTopper(names, marks);
            //Console.WriteLine($"Topper is {topper}");

            //int num = 5;
            //int square;
            //int cube;
            ////GetSquareAndCube(num, out square, out cube);
            ////Console.WriteLine($"Num = {num}, " +
            ////    $"Square = {square}, Cube = {cube}");

            //bool success = false;
            //do
            //{
            //    success = int.TryParse(Console.ReadLine(), out int age);
            //    if (success)
            //    {
            //        Console.WriteLine($"Age = {age}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Wrong Age entered - {age}");
            //    }
            //} while (!success);

            //double bill = CalculateGymBill(true, false, false);
            //Console.WriteLine($"Gym Bill = {bill:f2}");

            //PrintLine();
            //PrintLine(ch: '$');
            //PrintLine(ch: '$', num: 55);
            //PrintLine(70);
            //PrintLine(60, '+');

            //MultipleDefParameters(d: 6, e: 7);
            //MultipleDefParameters(6, 7);

            int x = 10;
            InParamMethod(x);

        }

        static void InParamMethod(in int y)
        {
            //y++;    // read only
        }



        //static void MultipleDefParameters(
        //            int a=1, int b=2, int c=3, int d=4, int e=5)
        //{
        //    Console.WriteLine($"a-{a} b-{b} c-{c} d-{d} e-{e}");
        //}

        //static void PrintLine(int num = 40, char ch = '-')
        //{
        //    for (int i = 0; i < num; i++)
        //    {
        //        Console.Write(ch);
        //    }
        //    Console.WriteLine();
        //}

        //static void PrintLine()
        //{
        //    for (int i = 0; i < 40; i++)
        //    {
        //        Console.Write('-');
        //    }
        //    Console.WriteLine();
        //}
        //static void PrintLine(char ch)
        //{
        //    for (int i = 0; i < 40; i++)
        //    {
        //        Console.Write(ch);
        //    }
        //    Console.WriteLine();
        //}






        static double CalculateGymBill(bool tread, bool weight, bool zumba)
        {
            double bill = 1000.0;
            if (tread || weight || zumba)
            {
                bill += tread ? 300 : 0;
                if (weight) bill += 500;
                if (zumba) bill += 250;
            }
            else
            {
                bill += 200;
            }
            bill += bill * 0.05;
            return bill;
        }






        static void GetSquareAndCube(int num,
                            out int square, out int cube)
        {
            square = Convert.ToInt32(Math.Pow(num, 2));
            cube = Convert.ToInt32(Math.Pow(num, 3));
        }



        static int GetDoubleSquareAndCube(int num,
                            out int square, out int cube)
        {
            square = Convert.ToInt32(Math.Pow(num, 2));
            cube = Convert.ToInt32(Math.Pow(num, 3));
            return num * 2;
        }







        // create 2 arrays to store 5 student names 
        // and to store 5 student marks respectively
        // create a method to get student name with max marks

        static string GetNameOfTopper(string[] names, int[] marks)
        {
            int highestMarks = marks.Max();
            int position = Array.IndexOf(marks, highestMarks);
            return names[position];
        }













        static void ChangeValue(ref int num)
        {
            num++;
            Console.WriteLine($"num={num}");
        }




        static int[] GetOddNumbers(int num)
        {
            int size = num % 2 == 0 ? (num / 2) : (num / 2) + 1;
            Console.WriteLine(size);
            int[] arr = new int[size];
            int index = 0;
            for (int i = 1; i <= num; i = i + 2)
            {
                arr[index++] = i;
            }
            return arr;
        }

        // method with return type
        static int GetSquare(int num)
        {
            return num * num;
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello World");
        }

        // Method Overloading
        public static void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }

    class DemoMethods
    {
        public static void CallAnotherClassMethod()
        {
            Console.WriteLine("CallAnotherClassMethod called");

        }
    }
}
