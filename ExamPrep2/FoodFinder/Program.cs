using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "pear", "flour", "pork","olive"
            };
            List<string> output = new List<string>();

            char[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            char[] input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

            foreach (var item in list)
            {
                bool match = true;
                foreach (var ch in item)
                {
                    if (!input.Contains(ch) && !input2.Contains(ch))
                    {
                        match = false;
                    }
                }
                if (match)
                    output.Add(item);
            }
            Console.WriteLine($"Words found: {output.Count}" + Environment.NewLine +
                $"{string.Join(Environment.NewLine, output)}");

        }
    }
}
