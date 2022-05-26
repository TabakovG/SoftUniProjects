using System;
using System.Collections.Generic;

namespace Wardrobe
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string,int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < num; i++)
            {
                string[] cmd = Console.ReadLine().Split(" -> ");
                string key = cmd[0];
                string[] values = cmd[1].Split(",");

                if (!wardrobe.ContainsKey(key))
                {
                    wardrobe[key] = new Dictionary<string, int>();
                }

                foreach (var clothes in values)
                {
                    if (!wardrobe[key].ContainsKey(clothes))
                    {
                        wardrobe[key][clothes] = 0;
                    }
                    wardrobe[key][clothes]++;
                }
            }
            string[] request = Console.ReadLine().Split();

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var cloth in color.Value)
                {
                    Console.Write($"* {cloth.Key} - {cloth.Value}");
                    if (color.Key==request[0] && cloth.Key==request[1])
                    {
                        Console.Write(" (found!)");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }

        }
    }
}
