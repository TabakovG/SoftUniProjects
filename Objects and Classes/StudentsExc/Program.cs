using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsExc
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();

                Student student = new Student(input[0], input[1], double.Parse(input[2]));
                students.Add(student);
            }

            List<Student> orderedList = students.OrderByDescending(x => x.Grade).ToList();
            foreach (var std in orderedList)
            {
                Console.WriteLine($"{std.FirstName} {std.LastName}: {std.Grade:f2}");
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string fName, string lName, double grade)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Grade = grade;
        }
    }
}
