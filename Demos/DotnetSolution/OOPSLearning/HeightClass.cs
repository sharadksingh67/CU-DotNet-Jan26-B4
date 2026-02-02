using System.Text.RegularExpressions;

namespace OOPSLearning
{
    internal class HeightClass
    {
        static void Main(string[] args)
        {
            //Height person1 = new Height(5, 6.5);
            //Height person2 = new Height(67.5);

            //Height total = person1 + person2;
            ////Height total = person1.AddHeights(person2);

            //Console.WriteLine(person1);
            //Console.WriteLine(person2);
            //Console.WriteLine(total);


            //string input = "9988    776     655 ";
            //string s1 = Regex.Replace(input, @"[ ]{1,}", @"");
            //Console.WriteLine(s1);

            //Console.WriteLine(input);
            //string pattern = @"[9]{2}[0-9]{8}";
            //Console.WriteLine(Regex.IsMatch(input, pattern));

            string pattern = @"(Mr.? |Mrs.? |Miss |Ms.? )";
            string[] names = { "Mr. Henry Hunt", "Mrs. Sara Samuels",
                         "Mrs Abraham Adams", "Ms. Nicole Norris",
                         "Mr Abraham Adams", "Ms. Nicole Norris"
            };

            foreach (string name in names)
                Console.WriteLine(Regex.Replace(name, pattern, String.Empty));

        }
    }
    class Height
    {
        public int Feet { get; set; }
        public double Inches { get; set; }

        //Default Constructor 
        public Height()
        {
            Feet = 0;
            Inches = 0.0;
        }

        //Parameterized Constructor
        public Height(int feet, double inches)
        {
            Feet = feet;
            Inches = inches;
        }

        //constructor which take only single parameter
        public Height(double totalInches)
        {
            if (totalInches >= 12)
            {
                Feet = (int)totalInches / 12;
                Inches = totalInches % 12;
            }
            else
            {
                Feet = 0;
                Inches = totalInches;
            }
        }

        public static Height operator +(Height h1, Height h2)
        {
            int totalFeet = h1.Feet + h2.Feet;
            double totalInches = h1.Inches + h2.Inches;

            if (totalInches >= 12)
            {
                totalFeet += (int)(totalInches / 12);
                totalInches = totalInches % 12;
            }
            return new Height(totalFeet, totalInches);
        }

        //Method
        public Height AddHeights(Height h2)
        {
            int totalFeet = this.Feet + h2.Feet;
            double totalInches = this.Inches + h2.Inches;

            if (totalInches >= 12)
            {
                totalFeet += (int)(totalInches / 12);
                totalInches = totalInches % 12;
            }
            return new Height(totalFeet, totalInches);
        }

        //Override
        public override string ToString()
        {
            return $"Height - {Feet} feet {Inches} inches";
        }
    }
}
