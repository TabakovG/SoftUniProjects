using System;
using System.Collections.Generic;
using System.Linq;

namespace Applied_Arithmetics
{
    internal class Applied_Arithmetics
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<List<int>, List<int>> add = list => list.Select(x => x + 1).ToList();
            Func<List<int>, List<int>> multiply = list => list.Select(x => x * 2).ToList();
            Func<List<int>, List<int>> subtract = list => list.Select(x => x - 1).ToList();
            Action<List<int>> printNums = list => Console.WriteLine(String.Join(" ", list));

            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                {
                    nums = add(nums);
                }
                else if (command == "multiply")
                {
                    nums = multiply(nums);
                }
                else if (command == "subtract")
                {
                    nums = subtract(nums);
                }
                else if (command == "print")
                {
                    printNums(nums);
                }

                command = Console.ReadLine();
            }

        }

    }
}
