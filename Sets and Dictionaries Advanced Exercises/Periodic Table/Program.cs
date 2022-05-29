using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            SortedSet<string> set = new SortedSet<string>();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();

                foreach (var element in input)
                {
                    set.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", set));
        }
    }
}
