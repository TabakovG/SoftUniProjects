using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceSides = new Dictionary<string, List<string>>();

            string command;
            string[] separator = { " | ", " -> " };
            while ((command = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] cmd = command.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                if (command.Contains(" | "))
                {
                    string side = cmd[0];
                    string user = cmd[1];

                    if (!forceSides.ContainsKey(side))
                    {
                        forceSides[side] = new List<string>();
                    }
                    bool ignore = false;
                    foreach (var usr in forceSides.Values)
                    {
                        if (usr.Contains(user))
                        {
                            ignore = true;
                        }
                    }
                    if (!ignore) 
                    {
                        forceSides[side].Add(user);
                    }

                }
                else
                {
                    string user = cmd[0];
                    string side = cmd[1];

                    bool userExist = false;

                    foreach (var u in forceSides.Values)
                    {
                        if (u.Contains(user))
                        {
                            userExist = true;
                            u.Remove(user);
                            if (!forceSides.ContainsKey(side))
                            {
                                forceSides[side] = new List<string>();
                            }
                                forceSides[side].Add(user);
                            Console.WriteLine($"{user} joins the {side} side!");
                            break;
                        }
                    }
                    if (!userExist)
                    {
                        if (!forceSides.ContainsKey(side))
                        {
                            forceSides[side] = new List<string>();
                        }
                        forceSides[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }

            }

            foreach (var fSide in forceSides.OrderByDescending(c=>c.Value.Count).ThenBy(n=>n.Key).Where(members=>members.Value.Count > 0) )
            {
                Console.WriteLine($"Side: {fSide.Key}, Members: {fSide.Value.Count}");
                foreach (var member in fSide.Value.OrderBy(n=>n))
                {
                    Console.WriteLine($"! {member}");
                }
            }

        }
    }
}
