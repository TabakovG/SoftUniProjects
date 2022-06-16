using System;
using System.Linq;

namespace CustomComparator
{
    internal class StartUp
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int, int> sort = (x, y) =>
                {
                    if (x % 2 == 0 && y % 2 != 0)
                        return -1;
                    else if (x % 2 != 0 && y % 2 == 0)
                        return 1;
                    else
                        return x.CompareTo(y);
                };


            Array.Sort(nums, (int x, int y)=>sort(x,y));

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
