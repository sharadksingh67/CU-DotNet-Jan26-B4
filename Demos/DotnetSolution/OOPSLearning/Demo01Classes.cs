//namespace OOPSLearning
//{
//    class Person
//    {
//        // data members

//        string personName = string.Empty;

//        public string FirstName { get; set; }
//        public string LastName { get; set; }

//        // Read-Only Property
//        public string FullName
//        {
//            get { return $"{FirstName} {LastName}"; }            
//        }



//        // methods

//        public void SetName(string name)
//        {
//            personName = name;
//        }
//        public void GetName()
//        {
//            Console.WriteLine($"{personName}");
//        }

//        // properties

//        public int age;

//        //public int Age
//        //{
//        //    get { return age; }
//        //    set { 
//        //    if(value >0 && value< 100)    
//        //        age = value; 
//        //    }
//        //}

//        private string city;

//        public string City
//        {
//            get { return city; }
//            set { city = value; }
//        }

//        public string Mobile { get; set; }

//        public  void Display1()
//        {
//            Console.WriteLine("Display1");
//        }
//    }

   
//    class Demo01Classes
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("OOPS Started!");
//            Person person1 = new Person();

//            person1.FirstName = "Amit";
//            person1.LastName = "Sharma";
//            //person1.SetName("Person1");
//            //person1.GetName();

//            //person1.age = -2786862;
//            //Console.WriteLine(person1.age);

//            //person1.City = "CHD";
//            //Console.WriteLine(person1.City);

//            //person1.Mobile = "9844556677";
//            //Console.WriteLine(person1.Mobile);

//            Console.WriteLine( person1.age = 50 );
//            Console.WriteLine(person1.FullName);

//        }
//    }
//}
