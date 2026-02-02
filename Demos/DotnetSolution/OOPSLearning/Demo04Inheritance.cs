//namespace OOPSLearning
//{
//    class Person
//    {
//        public Person()
//        {
//            AadharId = 0;
//            Name = string.Empty;
//#if DEBUG
//            Console.WriteLine("*******Person Default Constructor");
//#endif
//        }
//        public Person(int id, string name)
//        {
//            AadharId = id;
//            Name = name;
//#if DEBUG
//            Console.WriteLine("Person overloaded Constructor");
//#endif
//        }
//        public int AadharId { get; set; }
//        public string Name { get; set; }

//        public override string ToString()
//        {
//            return $"Id - {AadharId}, Name - {Name}";
//        }

//        public void Display()
//        {
//            Console.WriteLine("Person Displayed...");
//        }
//    }

//    class Student : Person
//    {
//        public new string Name { get; set; }
//        public string Degree { get; set; }
//        public string College { get; set; }
//        public Student()
//        {
//            Degree = string.Empty;
//            College = string.Empty;
//            Console.WriteLine("Student Default Constructor");
//        }
//        public Student(string degree, string college)
//        {
//            Degree = degree;
//            College = college;
//        }

//        public Student(int id, string name,
//            string degree, string college)
//            : base(id, name)
//        {
//            Degree = degree;
//            College = college;
//            Console.WriteLine("Student overloaded Constructor");
//        }
//        public new void Display()
//        {
//            Console.WriteLine("Student Displayed...");
//        }
//        public override string ToString()
//        {
//            return base.ToString() +
//                $" Degree - {Degree}, College - {College}";
//        }
//    }

//    class Player : Person
//    {
//        public string Sport { get; set; }
//        public new void Display()
//        {
//            Console.WriteLine("Player Displayed...");
//        }

//    }
//    internal class Demo04Inheritance
//    {
//        static void Main(string[] args)
//        {
//            // Person person1 = new Person();

//            Person[] persons = new Person[4]
//            {
//                new Student(),  // anonymous object
//                new Student(),
//                new Player(),
//                new Player()
//            };
//            Student s1 = new Student(1111, "Stud1",
//                                "BSc", "College1");

//            Student s2 = new Student(1112, "Stud2",
//                                "BSc", "College1");

//            Player p1 = new Player();
//            Player p2 = new Player();

//            s1.Display();
//            p1.Display();






//            persons[0] = s1;
//            persons[1] = s2;
//            persons[2] = p1;
//            persons[3] = p2;

//            for (int i = 0; i < persons.Length; i++)
//            {
//                persons[i].Display();
//            }

//            Console.WriteLine();
//        }
//    }
//}
