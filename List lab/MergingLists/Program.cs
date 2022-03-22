using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < Math.Min(numbers1.Count, numbers2.Count); i++)
            {
                result.Add(numbers1[i]);
                result.Add(numbers2[i]);
            }
            for (int j = Math.Min(numbers1.Count, numbers2.Count); j < Math.Max(numbers1.Count, numbers2.Count); j++)
            {
                if (numbers1.Count > numbers2.Count)
                {
                    result.Add(numbers1[j]);
                }
                else if (numbers1.Count < numbers2.Count)
                {
                    result.Add(numbers2[j]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
