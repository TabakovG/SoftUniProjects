using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Average_Student_Grades
{
    internal class Program
    {
        static void Main()
        {
            var students = new Dictionary<string,List<decimal>>();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string name = input[0];
            decimal grade = decimal.Parse(input[1]);

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<decimal>();
                }
                students[name].Add(grade);
            }

            foreach (var item in students)
            {
                string grades = string.Join(" ", item.Value.Select(v=>v.ToString("f2")));
                Console.WriteLine($"{item.Key} -> {grades} (avg: {item.Value.Average():f2})");
            }
        }
    }
}
