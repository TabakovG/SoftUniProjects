using System;
using System.Collections.Generic;

namespace Parking_Lot
{
    internal class Program
    {
        static void Main()
        {
            HashSet<string> set = new HashSet<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                        PrintCars(set);
                        break;
                }
                if (command.StartsWith("IN"))
                {
                    set.Add(command.Substring(4));
                }
                else
                {
                    set.Remove(command.Substring(5));
                }

            }
        }

        private static void PrintCars(HashSet<string> set)
        {
            if (set.Count > 0)
            {
                foreach (var item in set)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
