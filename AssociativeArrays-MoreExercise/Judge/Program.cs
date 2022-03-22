using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> judge= new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();
            while (command != "no more time")
            {
                string[] cmd = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string username = cmd[0];
                string contest = cmd[1];
                int points = int.Parse(cmd[2]);

                if (!judge.ContainsKey(contest))
                {
                    judge[contest] = new Dictionary<string, int>();
                }

                if (!judge[contest].ContainsKey(username))
                {
                    judge[contest][username] = 0;
                }

                if (judge[contest][username]<points)
                {
                    judge[contest][username] = points;
                }
                

                command = Console.ReadLine();
            }

            foreach (var item in judge)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count} participants");
                int position = 1;
                foreach (var user in item.Value.OrderByDescending(v=> v.Value).ThenBy(name=>name.Key))
                {
                    Console.WriteLine($"{position}. {user.Key} <::> {user.Value}");
                    position++;
                }

            }

            var totalPoints = new Dictionary<string, int>();

            foreach (var item in judge)
            {
                foreach (var user in item.Value)
                {
                    if (!totalPoints.ContainsKey(user.Key))
                    {
                        totalPoints[user.Key] = 0;
                    }
                    totalPoints[user.Key] += user.Value;

                }
            }
            Console.WriteLine($"Individual standings:");
            int positionInd = 1;
            foreach (var item in totalPoints.OrderByDescending(v=>v.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{positionInd}. {item.Key} -> {item.Value}");
                positionInd++;
            }
        }
    }
}
