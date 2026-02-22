using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCSConsole
{
    internal class NextChar
    {
        static void Main(string[] args)
        {
            string vowels = "aeiou";
            string s = "crypt";
            //output    ecdfa      
            string output = string.Empty;

            foreach (char c in s)
            {
                if (!vowels.Contains(c))
                {
                    char ch = (char)(c + 1);
                    if (vowels.Contains(ch))
                        ch = (char)((int)ch + 1);
                    output += ch;
                }
                else
                {
                    int index = vowels.IndexOf(c);
                    if (index != 4)
                        output += vowels[index + 1];
                    else
                        output += vowels[0];
                }
            }
            Console.WriteLine(output);

        }
    }
}
