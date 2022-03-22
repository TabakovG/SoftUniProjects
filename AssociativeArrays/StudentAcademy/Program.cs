using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> std = new Dictionary<string, List<double>>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!std.ContainsKey(name))
                {
                    std[name] = new List<double>();
                }
                std[name].Add(grade);
            }

            foreach (var item in std.Where(s => s.Value.Average()>=4.5))
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
            }
        }
    }
}
