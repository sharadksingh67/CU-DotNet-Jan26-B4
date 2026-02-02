//namespace OOPSLearning
//{
//    abstract class Person
//    {
//        public Person()
//        {
//            AadharId = 0;
//            Name = string.Empty;
//            Console.WriteLine("Person Default Constructor");
//        }
//        public Person(int id, string name)
//        {
//            AadharId = id;
//            Name = name;
//            Console.WriteLine("Person overloaded Constructor");
//        }
//        public int AadharId { get; set; }
//        public string Name { get; set; }

//        public override string ToString()
//        {
//            return $"Id - {AadharId}, Name - {Name}";
//        }

//        public virtual void Display()
//        {
//            Console.WriteLine("Person Displayed...");
//        }

//        public abstract void AbstractMethod();
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
//        public override void Display()
//        {
//            Console.WriteLine("Student Displayed...");
//        }
//        public override string ToString()
//        {
//            return base.ToString() +
//                $" Degree - {Degree}, College - {College}";
//        }

//        public override void AbstractMethod()
//        {
//            Console.WriteLine("Abstract method implemented in Student" );
//        }
//    }

//    class Player : Person
//    {
//        public string Sport { get; set; }
//        public override void Display()
//        {
//            Console.WriteLine("Player Displayed...");
//        }
//        public override void AbstractMethod()
//        {
//            Console.WriteLine("Abstract method implemented in Player");
//        }
//    }
//    internal class Demo05Polymorphism
//    {
//        static void Main(string[] args)
//        {
//            // Person person1 = new Person();

//            Person[] persons = new Person[4]
//            {
//                        new Student(),  // anonymous object
//                        new Student(),
//                        new Player(),
//                        new Player()
//            };

//            for (int i = 0; i < persons.Length; i++)
//            {
//                persons[i].Display();
//                persons[i].AbstractMethod();
//            }
//        }
//    }
//}

