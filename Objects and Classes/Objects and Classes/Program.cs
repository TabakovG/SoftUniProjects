using System;
using System.Collections.Generic;
using System.Linq;

namespace Objects_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            for (int i = 0; i < input.Count; i++)
            {
                string currentItem = input[i];
                Random randomIndex = new Random();
                input.RemoveAt(i);
                input.Insert(randomIndex.Next(0, input.Count), currentItem);
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
