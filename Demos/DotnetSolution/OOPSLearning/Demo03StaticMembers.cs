//namespace OOPSLearning
//{
//    class Employee
//    {
//        static int incr;
//        public static string Company { get; set; }
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Department { get; set; }
//        static Employee()   // class level constructor
//        {
//            incr = 1110;
//            Company = "Capgemini";
//            Console.WriteLine("Static Constructor");
//        }
//        public Employee()
//        {
//            incr++;
//            Id = incr;
//            Console.WriteLine("Default Constructor");
//        }
//        public static void ChangeCompany(string cname)
//        {
//            Company = cname;
//        }
//        public override string ToString()
//        {
//            return $"Id - {Id} Name - {Name} " +
//                $"Dept - {Department} Company - {Company}";
//        }

//        public override bool Equals(object? obj)
//        {
//            Console.WriteLine("Trying Equals on Employees");
//            Employee e2 = obj as Employee; //(Employee)obj;
//            return (this.Name.Equals(e2.Name));            
//            //return base.Equals(obj);
//        }

//        public override int GetHashCode()
//        {
//            return this.GetHashCode();
//        }
//    }

//    internal class Demo03StaticMembers
//    {
//        static void Main(string[] args)
//        {
//            // Employee.Company = "Capgemini";
//            // Employee.ChangeCompany("NewCapgemini");
//            Employee e1 = new Employee()
//            {
//                // Id = 1111,
//                Name = "Employee1",
//                Department = "IT"
//            };
//            Employee e2 = new Employee()
//            {
//                // Id = 1112,
//                Name = "Employee1"
//            };
//            Console.WriteLine(e1);
//            Console.WriteLine(e2);
//            Console.WriteLine(e1.Equals(e2));
//        }
//    }
//}
