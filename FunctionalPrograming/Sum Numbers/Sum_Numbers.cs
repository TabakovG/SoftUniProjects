using System;
using System.Linq;

namespace Sum_Numbers
{
    internal class Sum_Numbers
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(nums.Length);
            Console.WriteLine(nums.Sum());
        }
    }
}
