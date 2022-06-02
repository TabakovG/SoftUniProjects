using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Min_Function
{
    internal class Custom_Min_Function
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int minNum = int.MaxValue;
            Func<int, int> getMin = x => x< minNum ? x : minNum;
            foreach (var item in nums)
            {
                minNum = getMin(item);
            }
            Console.WriteLine(minNum);
        }
    }
}
