using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = inputs[0];
            int s = inputs[1];
            int x = inputs[2];

            Queue<int> numbers = new Queue<int>();
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n && i < elements.Count(); i++)
            {
                numbers.Enqueue(elements[i]);
            }
            for (int i = 0; i < s; i++)
            {
                numbers.Dequeue();
            }
            if (numbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numbers.Any())
                {
                    Console.WriteLine(numbers.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
