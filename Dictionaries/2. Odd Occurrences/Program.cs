using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var item in words)
            {
                if (!dict.ContainsKey(item.ToLower()))
                {
                    dict.Add(item.ToLower(), 1);
                }
                else
                {
                    dict[item.ToLower()] += 1;
                }
            }

            foreach (var item in dict.Where(x => x.Value % 2 != 0))
            {
                Console.Write($"{item.Key} ");
            }
        }
    }
}
