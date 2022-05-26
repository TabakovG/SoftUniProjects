using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Sets_of_Elements
{
    internal class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nums[0];
            int m = nums[1];
            HashSet<string> setN = new HashSet<string>();
            HashSet<string> setM = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                setN.Add(Console.ReadLine());
            }
            for (int j  = 0; j < m; j++)
            {
                setM.Add(Console.ReadLine());
            }

            setN = setN.Where(x => setM.Contains(x)).ToHashSet();
            Console.WriteLine(String.Join(" ", setN));
        }
    }
}
