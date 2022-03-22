using System;
using System.Collections.Generic;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string cmd = Console.ReadLine();
            while (cmd != "End")
            {
                string[] emplInfo = cmd.Split(" -> ");

                if (!companies.ContainsKey(emplInfo[0]))
                {
                    companies[emplInfo[0]] = new List<string>();
                }
                if (!companies[emplInfo[0]].Contains(emplInfo[1]))
                {
                    companies[emplInfo[0]].Add(emplInfo[1]);
                }

                cmd = Console.ReadLine();
            }

            foreach (var item in companies)
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"-- {string.Join(Environment.NewLine + "-- ", item.Value)}");
            }
        }
    }
}
