using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Reverse_and_Exclude
{
    internal class Reverse_and_Exclude
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int specialNum = int.Parse(Console.ReadLine());

            Func<List<int>, List<int>> reverseArray = list => list.ToArray().Reverse().ToList();
                

            Func<List<int>, int, List<int>> removeDivisible = (list, x) => list.FindAll(num => num % x != 0).ToList();

            nums = reverseArray(nums);
            nums = removeDivisible(nums, specialNum);
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
