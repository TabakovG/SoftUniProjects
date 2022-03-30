using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StringBuilder stops = new StringBuilder();
            stops.Append(Console.ReadLine());

            string input = Console.ReadLine();
            while (input != "Travel")
            {
                string[] cmd = input.Split(":");
                string action = cmd[0];

                switch (action)
                {
                    case "Add Stop":
                        int index = int.Parse(cmd[1]);
                        string newStop = cmd[2];
                        if (index >= 0 && index < stops.Length)
                        {
                            stops.Insert(index, newStop);
                        }
                        break;
                    case "Remove Stop":
                        int startIndex = int.Parse(cmd[1]);
                        int endIndex = int.Parse(cmd[2]);

                        if (startIndex<=endIndex && startIndex >= 0 && endIndex < stops.Length)
                        {
                            int removeCount = endIndex - startIndex+1;
                            stops.Remove(startIndex, removeCount);
                        }
                        break;
                    case "Switch":
                        string old = cmd[1];
                        string newString = cmd[2];

                        stops.Replace(old, newString);
                        break;
                }

                Console.WriteLine(stops);

                input = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");

        }
    }
}
