using System.Text;
using System.Text.RegularExpressions;

namespace OOPSLearning
{
    internal class Demo11Regex
    {
        static void Main(string[] args)
        {
            string pan = "ABCDE1234Z";
            bool validPan = Regex.IsMatch(pan, @"^[A-Z]{5}[0-9]{4}[A-Z]{1}$");
            Console.WriteLine(validPan);

            string mob = "99887-76655";
            bool validMob = Regex.IsMatch(mob, @"^[7-9]{2}[0-9]{3}-[0-9]{5}$");
            Console.WriteLine(validMob);

            string name = "Sharad";
            bool validFirstName = Regex.IsMatch(name, @"^[A-Z]{1}[a-z]{2,}$");
            Console.WriteLine(validFirstName);

            string fullName = "Sharad Singh";
            bool validFullName = Regex.IsMatch(fullName, 
                        @"^[A-Z]{1}[a-z]{2,}[ ]{1}[A-Z]{1}[a-z]{2,}$");
            Console.WriteLine(validFullName);

        }
    }
}
