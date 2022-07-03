
using System;
using System.Collections.Generic;
using System.Linq;

namespace LootBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> first = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> second = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            List<int> list = new List<int>();

            while (first.Count > 0 && second.Count > 0)
            {
                int firstEl = first.Peek();
                int secondEl = second.Peek();
                if ((firstEl + secondEl ) % 2 == 0)
                {
                    list.Add(firstEl+ secondEl);
                    first.Dequeue();
                    second.Pop();
                }
                else
                    first.Enqueue(second.Pop());
            }
            if (first.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (list.Sum() >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {list.Sum()}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {list.Sum()}");
            }
        }
    }
}
