using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd;
            Dictionary<string, string> contestPass = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> studentCources = new Dictionary<string, Dictionary<string, int>>();

            while ((cmd = Console.ReadLine()) != "end of contests")
            {
                string[] course = cmd.Split(':');
                contestPass[course[0]] = course[1];
            }

            string input;
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] submissions = input.Split("=>");

                string courseName = submissions[0];
                string coursePass = submissions[1];
                string student = submissions[2];
                int points = int.Parse(submissions[3]);

                if (InputIsValid(courseName, coursePass, contestPass))
                {
                    if (!studentCources.ContainsKey(student))
                    {
                        studentCources[student] = new Dictionary<string, int>();
                    }
                    if (!studentCources[student].ContainsKey(courseName))
                    {
                        studentCources[student][courseName] = 0;
                    }
                    studentCources[student][courseName] = 
                        studentCources[student][courseName] < points ? points
                        : studentCources[student][courseName];
                }

            }

            var bestStudent = studentCources.OrderByDescending(p => p.Value.Values.Sum()).FirstOrDefault();

            Console.WriteLine($"Best candidate is {bestStudent.Key} with total {bestStudent.Value.Values.Sum()} points.");
            Console.WriteLine("Ranking:");
            foreach (var candidate in studentCources.OrderBy(n=>n.Key))
            {
                Console.WriteLine($"{candidate.Key}");
                foreach (var c in candidate.Value.OrderByDescending(p=>p.Value))
                {
                    Console.WriteLine($"#  {c.Key} -> {c.Value}");
                }
            }


        }

        private static bool InputIsValid(string courseName, string coursePass, Dictionary<string, string> contestPass)
        {
            if (contestPass.ContainsKey(courseName))
            {
                if (contestPass[courseName] == coursePass)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
