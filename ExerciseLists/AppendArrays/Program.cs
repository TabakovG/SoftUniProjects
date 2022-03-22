using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<int> newList = new List<int>();
            for (int i = input.Count-1; i >= 0; i--)
            {
                List<int> numbers = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                newList.AddRange(numbers);
            }
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
