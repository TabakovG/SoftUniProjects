using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int countComm = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < countComm; i++)
            {
                List<string> commands = Console.ReadLine().Split().ToList();

                if (commands[2] == "going!")
                {
                    if (!guestList.Contains(commands[0]))
                    {
                        guestList.Add(commands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commands[0]} is already in the list!");
                    }
                }
                else
                {
                    if (guestList.Contains(commands[0]))
                    {
                        guestList.Remove(commands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commands[0]} is not in the list!");
                    }
                }

            }

            for (int i = 0; i < guestList.Count; i++)
            {
                Console.WriteLine(guestList[i]);
            }
        }
    }
}
