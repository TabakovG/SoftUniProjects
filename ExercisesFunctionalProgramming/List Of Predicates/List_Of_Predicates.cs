
using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Of_Predicates
{
    internal class List_Of_Predicates
    {
        static void Main()
        {
            int rangeEnd = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] nums = Enumerable.Range(1, rangeEnd).ToArray();

            Func<int[], int, int[]> getDivisible = (input, number) =>
            {
                List<int> newList = new List<int>();
                foreach (var n in input)
                {
                    if (n % number == 0)
                        newList.Add(n);
                }
                return newList.ToArray();

            };

            foreach (var divider in dividers)
            {
                nums = getDivisible(nums, divider);
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
