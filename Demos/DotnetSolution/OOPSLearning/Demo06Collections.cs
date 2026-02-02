using System.Collections;

namespace OOPSLearning
{

    
    internal class Demo06Collections
    {
        static IEnumerable<int> GetFactorial(int num)
        {
            int fact = 1;
            for (int i = 2; i <= num; i++)
            {
                fact *= i;
                yield return fact;
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(GetFactorial(5));

            //foreach (var item in GetFactorial(5))
            //{
            //    Console.WriteLine(item);
            //}

            //int[] arr = { 2, 7, 8, 3, 4 };
            //for (int j = 0; j < arr.Length; j++)
            //{
            //    arr[j] += 1;
            //    Console.WriteLine(arr[j]);
            //}
            //foreach (var item in arr)
            //{
            //    item++;
            //    Console.WriteLine(item);
            //}

            // non-generic collection
            //ArrayList list = new ArrayList();
            //list.Add(12);
            //list.Add("abc");
            //list.Add(5.5);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}


            //List<int> marks = new List<int>
            //{
            //    44,55,66,77,88
            //};

            //foreach (var item in marks)
            //{
            //    Console.WriteLine(item);
            //}

            //marks.Add(99);
            //marks.Insert(3, 22);
            //Console.WriteLine(marks.Count);
            //Console.WriteLine(string.Join(",",marks));


       
        }
    }
}
