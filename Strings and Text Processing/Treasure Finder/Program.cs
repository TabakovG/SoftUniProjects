using System;
using System.Collections.Generic;
using System.Linq;

namespace Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            Dictionary<string, string> treasures = new Dictionary<string, string>();

            string cmd = Console.ReadLine();
            while (cmd != "find")
            {
                string hiddenMsg = string.Empty;
                int indexKey = 0;
                foreach (char ch in cmd)
                {
                    hiddenMsg += (char)(ch - numbers[indexKey]);
                    indexKey++;
                    if (indexKey > numbers.Length - 1)
                    {
                        indexKey = 0;
                    }
                }
                string key = hiddenMsg.Split('&')[1];
                string value = hiddenMsg.Split(new char[] {'<', '>'})[1];

                treasures[key] = value;
                cmd = Console.ReadLine();
            }

            foreach (var item in treasures)
            {
                Console.WriteLine($"Found {item.Key} at {item.Value}");
            }

        }
    }
}
