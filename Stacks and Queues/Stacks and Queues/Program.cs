using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = inputs[0];
            int s = inputs[1];
            int x = inputs[2];

            Stack<int> numbers = new Stack<int>();
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n && i < elements.Count(); i++)
            {
                numbers.Push(elements[i]);
            }
            for (int i = 0; i < s; i++)
            {
                numbers.Pop();
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
