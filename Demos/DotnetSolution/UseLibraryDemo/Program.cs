using MyClassLibrary;

namespace UseLibraryDemo
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            int result = MyMath.GetDouble(11);
            Console.WriteLine(result);
            Console.WriteLine(".NET Project Running");
        }

    }
}
