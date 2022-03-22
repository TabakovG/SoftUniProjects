using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> words = new Dictionary<char, int>();

            foreach (char item in input.Where(c => c != ' '))
            {
                if (!words.ContainsKey(item))
                {
                    words.Add(item, 1);
                }
                else
                {
                    words[item] += 1;
                }
            }

            foreach (var item in words)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
