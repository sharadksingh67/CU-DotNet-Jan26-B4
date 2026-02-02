namespace OOPSLearning
{
    class MyArray<T>
    {
        public T[] arr = new T[5];

        public T this[int index]
        {
            get { return (T)arr[index]; }
            set { arr[index] = (T)value; }
        }

    }

    //class MyStringArray
    //{
    //    public string[] arr = new string[5];

    //}

    internal class Demo08GenericClass
    {
        static void Main(string[] args)
        {
            MyArray<int> iarr = new MyArray<int>();
            iarr.arr[0] = 22;
            iarr[1] = 33; // will work with indexers
            Console.WriteLine(iarr[1]); 


            string s = "abcd";
            // s[0] = "x";   // read-only
            Console.WriteLine(s[0]);

            

            //Console.WriteLine(string.Join(",", iarr.arr));

            MyArray<string> sarr = new MyArray<string>();
            sarr.arr[0] = "abcd";
        }
    }
}
