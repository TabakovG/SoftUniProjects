using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalFood = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(input);

            Console.WriteLine(queue.Max());
            while (queue.Any())
            {
                if (queue.Peek() <= totalFood)
                {
                    totalFood -= queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {String.Join(' ', queue)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
