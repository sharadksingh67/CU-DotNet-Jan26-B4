//using System.Collections;

//namespace OOPSLearning
//{
//    class Laptop: IComparable<Laptop>
//    {
//        public int LaptopID { get; set; }
//        public string Company { get; set; }
//        public string ModelName { get; set; }
//        public int Price { get; set; }

//        public int CompareTo(Laptop? other)
//        {
//            return this.LaptopID.CompareTo(other?.LaptopID);
//        }

//        //public int CompareTo(object? obj)
//        //{
//        //    Laptop other = (Laptop)obj;
//        //    return this.LaptopID.CompareTo(other.LaptopID);
//        //}
//        public override string ToString()
//        {
//            return $"{LaptopID} {Company} {ModelName} {Price}";
//        }
//    }

//    class LaptopPriceSorter : IComparer<Laptop>
//    {
//        public int Compare(Laptop? x, Laptop? y)
//        {
//            return x.Price.CompareTo(y.Price);
//        }
//    }
//    class LaptopCompanySorter : IComparer<Laptop>
//    {
//        public int Compare(Laptop? x, Laptop? y)
//        {
//            return x.Company.CompareTo(y.Company);
//        }
//    }

//    internal class Demo07List
//    {
//        static void Main(string[] args)
//        {
//            //List<Laptop> laptops = new List<Laptop> {
//            //    new Laptop()
//            //        {
//            //            LaptopID = 105,
//            //            Company = "Lenovo",
//            //            ModelName = "Razor6",
//            //            Price = 500000
//            //        },
//            //    new Laptop()
//            //        {
//            //            LaptopID = 103,
//            //            Company = "Mac",
//            //            ModelName = "2CGa",
//            //            Price = 300000
//            //        },
//            //    new Laptop()
//            //        {
//            //            LaptopID = 104,
//            //            Company = "Asus",
//            //            ModelName = "G100BC",
//            //            Price = 900000
//            //        }
//            //};

//            //foreach (var laptop in laptops)
//            //{
//            //    Console.WriteLine(laptop);
//            //}

//            //// Array.Sort(laptops);

//            //// IComparer<Laptop> priceSorter =
//            //// new LaptopPriceSorter();

//            //// laptops.Sort(priceSorter);

//            //laptops.Sort(new LaptopPriceSorter());

//            ////Array.Sort(laptops);

//            //foreach (var laptop in laptops)
//            //{
//            //    Console.WriteLine(laptop);
//            //}

//            DateTime dt1 = 
//                new DateTime(2026, 1, 29, 23, 30, 0);

//            DateTime dt2 = DateTime.Parse("2026,01,29 10,25,30 am");
//            Console.WriteLine(dt2);

//            TimeSpan ts1 = new TimeSpan(1, 30, 0);
//            TimeSpan ts2 = new TimeSpan(2, 20, 0);
//            Console.WriteLine(ts1-ts2);

//            Console.WriteLine("Done");
//        }
//    }
//}
