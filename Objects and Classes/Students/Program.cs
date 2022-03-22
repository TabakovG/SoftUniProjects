using System;
using System.Collections.Generic;

namespace Students
{
    public class Student
    {
        public Student(string fName, string lName, int age, string town)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Age = age;
            this.HomeTown = town;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> group = new List<Student>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] studentInfo = input.Split();

                string fName = studentInfo[0];
                string lName = studentInfo[1];
                string age = studentInfo[2];
                string town = studentInfo[3];

                bool stdExist = false;

                foreach (var std in group)
                {
                    if (std.FirstName == fName && std.LastName == lName)
                    {
                        std.Age = int.Parse(age);
                        std.HomeTown = town;
                        stdExist = true;
                        break;
                    }
                }
                if (stdExist == false)
                {
                    group.Add(new Student(fName, lName, int.Parse(age), town));
                }

                input = Console.ReadLine();
            }

            string city = Console.ReadLine();

            foreach (var item in group)
            {
                if (item.HomeTown == city)
                {
                    Console.WriteLine($"{item.FirstName} { item.LastName} is {item.Age} years old.");
                }
            }


        }
    }
}
