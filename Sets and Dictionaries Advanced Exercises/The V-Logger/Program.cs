using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Logger
{
    internal class Program
    {
        static void Main()
        {
            string[] command = Console.ReadLine().Split();
            SortedDictionary<string, Vloger> vloggers = new SortedDictionary<string, Vloger>();


            while (command[0] != "Statistics")
            {

                if (command.Contains("joined"))
                {
                    if (!vloggers.ContainsKey(command[0]))
                    {
                        vloggers[command[0]] = new Vloger(command[0]);
                    }
                }
                else if (command.Contains("followed"))
                {
                    string firstVlogger = command[0];
                    string secondVlogger = command[2];

                    if (vloggers.ContainsKey(firstVlogger)
                        && vloggers.ContainsKey(secondVlogger)
                        && firstVlogger != secondVlogger
                        && !vloggers[firstVlogger].Following.Contains(secondVlogger))
                    {
                        vloggers[firstVlogger].Following.Add(secondVlogger);
                        vloggers[secondVlogger].Followers.Add(firstVlogger);
                    }
                }
                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count()} vloggers in its logs.");
            Vloger topV = vloggers.Values.OrderByDescending(f => f.Followers.Count).ThenBy(x => x.Following.Count).First();
            Console.WriteLine($"1. {topV.Name} : {topV.Followers.Count} followers, {topV.Following.Count} following");
            
            if (topV.Followers.Count > 0)
            {
                foreach (var follower in topV.Followers.OrderBy(n => n))
                {
                    Console.WriteLine($"*  {follower}");
                }
            }

            if (vloggers.Count > 1)
            {
                int no = 2;
                foreach (var v in vloggers.Values.OrderByDescending(f => f.Followers.Count).ThenBy(x => x.Following.Count).Where(v=> v.Name != topV.Name))
                {
                    Console.WriteLine($"{no}. {v.Name} : {v.Followers.Count} followers, {v.Following.Count} following");
                    no++;
                }
            }
        }
    }
    public class Vloger
    {
        public string Name { get; set; }
        public List<string> Followers { get; set; }

        public List<string> Following { get; set; }


        public Vloger(string name)
        {
            this.Name = name;
            Followers = new List<string>();
            Following = new List<string>();
        }
    }
}
