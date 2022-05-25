using System;
using System.Collections.Generic;

namespace Sets_and_Dictionaries_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (string s in input)
            {
                if (!result.ContainsKey(s))
                {
                    result[s] = 0;
                }
                result[s]++;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
