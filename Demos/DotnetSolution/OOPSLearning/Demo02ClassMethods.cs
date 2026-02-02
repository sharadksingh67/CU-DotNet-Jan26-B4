//namespace OOPSLearning
//{
//    class Employee
//    {
//        public int EmployeeId { get; set; }
//        public string FirstName { get; set; }
//        public string LastName { get; set; }

//        public string FullName
//        {
//            get { return $"{FirstName} {LastName}"; }
//        }

//        public string Department { get; set; }
//        public int Salary { get; set; }

//        public Employee()
//        {
//            EmployeeId = 1000;
//            // FullName = "sfdsf"; // read-only prop
//            FirstName = "New";
//            LastName = "Employee";
//            Department = "IT";
//            Salary = 25000;
//        }

//        //public void DisplayEmployee()
//        //{
//        //    Console.WriteLine($"Id - {EmployeeId} Name - {FullName} Department - {Department}");
//        //}

//        public override string ToString()
//        {
//            return $"Id - {EmployeeId} Name - " +
//                $"{FullName} Department - {Department} " +
//                $"Salary - {Salary}";
//        }

//        public bool IsMySalaryGreater(Employee emp)
//        {
//            return (this.Salary > emp.Salary);
//        }
//    }
//    internal class Demo02ClassMethods
//    {
//        static void Main(string[] args)
//        {
//            //int age = 22;
//            //Console.WriteLine(age.ToString());

//            //Employee employee1 = new Employee();
//            //Console.WriteLine(employee1);
//            ////employee1.DisplayEmployee();

//            // Object Initializer
//            Employee employee2 = new Employee()
//            {
//                EmployeeId = 2000,
//                Department = "Sales",
//                Salary = 30000,
//                FirstName = "Amit",
//                LastName = "Chauhan"
//            };

//            //Console.WriteLine(employee2);

//            Employee employee3 = new Employee()
//            {
//                EmployeeId = 3000,
//                Salary = 35000
//            };

//            Console.WriteLine(employee3);

//            bool salaryGreater =
//                employee2.IsMySalaryGreater(employee3);
//            Console.WriteLine(salaryGreater);
//        }
//    }
//}
