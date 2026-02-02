using System.Text;

namespace CS_Learning
{
    internal class Demo04StringRef
    {
        static void Main(string[] args)
        {

            //string name = "Abcd";
            //Console.WriteLine(name.GetHashCode());

            //name = name + "e";
            //Console.WriteLine(name.GetHashCode());

            //// index is used as a indexer
            //// a topic in OOPS
            //Console.WriteLine(name[2]);

            //string s1 = null;

            //char[] charr = { 'a', 'b' };
            //string s2 = new string(charr);

            //StringBuilder sb = new StringBuilder("abc");
            //Console.WriteLine(sb.GetHashCode());
            //string s2  = sb.ToString();

            //Console.WriteLine(s1.GetHashCode());
            //Console.WriteLine(s2.GetHashCode());

            // for string both check value equality
            //Console.WriteLine(s1 == s2);

            //Console.WriteLine(s1.Equals(s2));

            // Console.WriteLine(object.ReferenceEquals(s1, s2));

            //string[] values = { "aa", "bb", "cc", "dd" };
            ////aa,bb,cc,dd
            //for (int i = 0; i < values.Length; i++)
            //{
            //    if (i < values.Length - 1)
            //        Console.Write(values[i] + ",");
            //    else
            //        Console.Write(values[i]);
            //}
            //Console.WriteLine();

            // Console.WriteLine(string.Join(',',values));

            string s3 = string.Format($"abc    abcd");

            // Interpolated String  - $
            // Verbatim String      - @

            string path = @"c:\temp\data1.txt";

            string s4 = @" dsmfbjksdhjkfh


                        bdshfhsdjk


                                   sdlkfdsklh ";

            Console.WriteLine(s4);
        }
    }
}
