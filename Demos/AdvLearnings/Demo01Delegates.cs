using System.Collections;

namespace AdvLearnings
{

    static class MyString
    {
        public static int GetWordCounts(this string str)
        {
            int count = str.Split().Count();
            return count;
        }
    }

    internal class Demo01Delegates
    {
        static void Main(string[] args)
        {
            //string sentence = "This is a sentence";
            //int c = sentence.GetWordCounts();
            //Console.WriteLine(c);

            //ArrayList al = new ArrayList();
            //// Console.WriteLine(al.Capacity);
            //al.Add(123);
            //// Console.WriteLine(al.Capacity);
            //al.Add("abc");
            //al.Add(5.5);
            //al.Add(false);
            //al.Add(345);

            //foreach (object item in al)
            //{
            //    //int val = (int)item;
            //    //Console.WriteLine(item.GetType().Name);

            //    // Reflection
            //    Type type = item.GetType();
            //   int c = type.GetMethods().Count();

            //    int[] arr = { 1,2,3,4,5};
            //    Console.WriteLine(arr.Length);
            //    Console.WriteLine(arr.Count());

            //    if (item.GetType().Name == "Int32")
            //    //if(item is int)
            //        Console.WriteLine(item);
            //}

            //// Console.WriteLine(al.Capacity);
            //// Console.WriteLine(al.Count);


            ////HashSet<int> pincodes =
            ////    new HashSet<int>();

            ////bool added = false;
            ////added = pincodes.Add(201301);
            ////Console.WriteLine(added);
            ////pincodes.Add(140150);
            ////pincodes.Add(100001);
            ////added = pincodes.Add(201301);
            ////Console.WriteLine(added);
            ///

            //int[] arr = { 91, 81, 22, 36, 55, 78, 77, 75, 81 };
            //var result1 = arr
            //        .Where(x => x % 2 == 1)
            //        .OrderBy(x => x)
            //        .ToArray<int>();

            //Console.WriteLine(string.Join(",", result1));


            //Console.WriteLine("Done");


            //// 4
            //Console.WriteLine(GetWordCounts(sentence));

            // sentence.GetWordCounts();


            //Hashtable ht = new Hashtable();
            //ht.Add(1, "One");
            //ht.Add(2, "Two");
            //ht.Add(3, "Three");
            //ht.Add("a", "A");

            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine(item.Key +" - "+ item.Value);
            //}




            //Stack<int> values = new Stack<int>();
            //values.Push(11);
            //values.Push(22);
            //values.Push(33);

            //Console.WriteLine(values.Pop());


            //Queue<int> myQueue = new Queue<int>();
            //myQueue.Enqueue(11);
            //myQueue.Enqueue(22);
            //myQueue.Enqueue(33);

            //Console.WriteLine(myQueue.Dequeue());

            //Console.WriteLine("Done");

            SortedDictionary<int, string> sortedValues =
                new SortedDictionary<int, string>();

            sortedValues.Add(5, "Five");
            sortedValues.Add(1, "One");
            sortedValues.Add(4, "Four");
            sortedValues.Add(3, "Three");
            sortedValues.Add(2, "Two");

            foreach (var item in sortedValues)
            {
                Console.WriteLine(item.Key);
            }
        }

        static int GetWordCounts(string str)
        {
            int count = str.Split().Count();
            return count;
        }
    }


}
