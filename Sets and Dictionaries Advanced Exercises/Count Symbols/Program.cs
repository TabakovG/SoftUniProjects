using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Symbols
{
    internal class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            SortedDictionary<char, int> map = new SortedDictionary<char, int>();

            for (int i = 0; i < command.Length; i++)
            {
                
                if (!map.ContainsKey(command[i]))
                {
                    map[command[i]] = 0;
                }
                map[command[i]]++;
            }

            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
