using System.Threading.Channels;

namespace OOPSLearning
{
    internal class Demo09Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countryCapitals =
                            new Dictionary<string, string>();

            countryCapitals.Add("India", "Delhi");
            countryCapitals.Add("Australia", "Canberra");
            countryCapitals.Add("Afghanistan", "Kabul");
            countryCapitals.Add("Maldives", "Male");
            countryCapitals["Monaco"] = "Monaco";

            countryCapitals["India"] = "New Delhi";

            if (!countryCapitals.ContainsKey("Afghanistan"))
            {
                countryCapitals.Add("Afghanistan", "Kabul");
            }
            else
            {
                Console.WriteLine("Afghanistan - Key already existing!");
            }

            foreach (KeyValuePair<string, string> item in countryCapitals)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine("All the countries in my collection - ");

            foreach (string country in countryCapitals.Keys)
            {
                Console.WriteLine(country);
            }

            Console.WriteLine("All the capitals in my collection - ");

            foreach (string capital in countryCapitals.Values)
            {
                Console.WriteLine(capital);
            }

            bool isDeleted = countryCapitals.Remove("Afghanistan");
            if(isDeleted)
                Console.WriteLine("Country deleted...,");

            Console.Write("Enter a Country - ");
            string ctr = Console.ReadLine();

            string cap = string.Empty;
            bool existing =
                countryCapitals.TryGetValue(ctr, out cap);
            if (existing)
                Console.WriteLine($"{cap}");
            else
                Console.WriteLine($"Country {ctr} not existing");





            //ShowFreqDict();
        }

        static void ShowFreq()
        {
            string sentence = "This is a sentence.";
            // a-1
            // b-0
            // c-1
            // d-0
            sentence = sentence.ToLower();
            int[] freq = new int[26];
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] >= 'a' && sentence[i] <= 'z')
                    freq[sentence[i] - 'a']++;
            }
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine((char)('a' + i) + ":" + freq[i]);
            }
        }

        static void ShowFreqDict()
        {
            string sentence = "This is a sentence.";

            sentence = sentence.ToLower();

            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (var ch in sentence)
            {
                if (ch >= 'a' && ch <= 'z')
                    if (freq.ContainsKey(ch))
                        freq[ch] += 1;
                    else
                        freq[ch] = 1;
            }
            for (char ch = 'a'; ch<='z'; ch++)
            {
                if (freq.ContainsKey(ch))
                    Console.WriteLine($"{ch} - {freq[ch]}");
                else
                    Console.WriteLine($"{ch} - 0");
            }
        }
    }
}
