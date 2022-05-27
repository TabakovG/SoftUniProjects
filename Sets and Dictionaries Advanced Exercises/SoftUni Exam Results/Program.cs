using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> submissions = new Dictionary<string, int>();
            Dictionary<string, int> results = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] cmd = input.Split("-");

                if (cmd[1] != "banned")
                {
                    string student = cmd[0];
                    string lang = cmd[1];
                    int points = int.Parse(cmd[2]);
                  
                    if (!results.ContainsKey(student))
                    {
                        results[student] = 0;
                    }
                    results[student] =
                        results[student] < points ? points
                        : results[student];

                    if (!submissions.ContainsKey(lang))
                    {
                        submissions[lang] = 0;
                    }
                    submissions[lang]++;

                }
                else
                {
                    string username = cmd[0];
                    results.Remove(username);
                }

            }

            Console.WriteLine("Results:");

            foreach (var student in results.OrderByDescending(p => p.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var lang in submissions.OrderByDescending(p => p.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{lang.Key} - {lang.Value}");
            }

        }
    }
}
