using System;
using System.Collections.Generic;

namespace _2._AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, int> treasure = new Dictionary<string, int>();
            while (command != "stop")
            {
                int value = int.Parse(Console.ReadLine());
                if (!treasure.ContainsKey(command))
                {
                    treasure.Add(command, value);
                }
                else
                {
                    treasure[command] += value;
                }
                command = Console.ReadLine();
            }
            foreach (var item in treasure)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
