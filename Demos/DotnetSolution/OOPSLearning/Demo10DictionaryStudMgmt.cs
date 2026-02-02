using System.Text.RegularExpressions;

namespace OOPSLearning
{
    //Entity Class
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public override string ToString()
        {
            return $"Id - {Id} Name - {Name} Marks - {Marks}";
        }
    }

    //Manager Class 
    class StudentManager
    {
        Dictionary<int, Student> studentsData =
            new Dictionary<int, Student>();

        public bool AddStudent(Student student)
        {
            int id = student.Id;
            if (!studentsData.ContainsKey(id))
            {
                studentsData.Add(id, student);
                return true;
            }

            return false;
        }

        public bool UpdateStudent(int id, int marks)
        {
            Student foundStudent = SearchStudent(id);
            if (foundStudent != null)
            {
                foundStudent.Marks = marks;
                return true;
            }
            return false;
        }

        public bool DeleteStudent(int id)
        {
            return studentsData.Remove(id);
        }

        public Student SearchStudent(int id)
        {
            Student student = null;
            bool found = studentsData.TryGetValue(id, out student);

            return student;
        }

        public void DisplayAllStudents()
        {
            foreach (var student in studentsData)
            {
                Console.WriteLine(student.Value);
            }
        }

    }



    internal class Demo10DictionaryStudMgmt
    {
        static void Main(string[] args)
        {
            //StudentManager manager = new StudentManager();
            //manager.AddStudent(
            //    new Student()
            //    {
            //        Id = 111,
            //        Name = "Student1",
            //        Marks = 78
            //    });

            //manager.AddStudent(
            //    new Student()
            //    {
            //        Id = 112,
            //        Name = "Student2",
            //        Marks = 88
            //    });

            //int searchId = 115;
            //Student foundStudent = manager.SearchStudent(searchId);
            //if (foundStudent == null)
            //    Console.WriteLine($"Student with {searchId} not found");
            //else
            //    Console.WriteLine(foundStudent);

            //Console.WriteLine("------------------------");

            //bool updated = manager.UpdateStudent(111, 80);
            //if (updated)
            //{
            //    Console.WriteLine(manager.SearchStudent(111));
            //}

            //Console.WriteLine("------------------------");

            //bool deleted = manager.DeleteStudent(112);
            //if (deleted)
            //{
            //    Console.WriteLine("Student Deleted");
            //}

            //manager.DisplayAllStudents();



           

        }
    }
}
