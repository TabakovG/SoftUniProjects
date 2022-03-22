using System;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string cmd = Console.ReadLine();
            while (cmd != "end")
            {
                string[] std = cmd.Split(" : ");

                if (!courses.ContainsKey(std[0]))
                {
                    courses[std[0]] = new List<string>();
                }
                    courses[std[0]].Add(std[1]);

                cmd = Console.ReadLine();
            }

            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                Console.WriteLine($"-- {string.Join(Environment.NewLine + "-- ", item.Value)}");
            }
        }
    }
}
