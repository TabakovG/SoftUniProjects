using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, string> reg = new Dictionary<string, string>();

            for (int i = 0; i < num; i++)
            {
                string[] cmd = Console.ReadLine().Split();

                switch (cmd[0])
                {
                    case "register":

                        if (reg.ContainsKey(cmd[1]))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {reg[cmd[1]]}");
                        }
                        else
                        {
                            reg[cmd[1]] = cmd[2];
                            Console.WriteLine($"{cmd[1]} registered {cmd[2]} successfully");
                        }
                        break;
                    case "unregister":
                        if (!reg.ContainsKey(cmd[1]))
                        {
                            Console.WriteLine($"ERROR: user {cmd[1]} not found");
                        }
                        else
                        {
                            reg.Remove(cmd[1]);
                            Console.WriteLine($"{cmd[1]} unregistered successfully");
                        }
                        break;
                }

            }
            foreach (var item in reg)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
