
using System;
using System.Linq;

namespace Find_Evens_or_Odds
{
    internal class Find_Evens_or_Odds
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var range = Enumerable.Range(input[0], input[1] - input[0]+1);
            Predicate<int> type = x => false;
            string cmd = Console.ReadLine();
            if (cmd == "odd")
            {
                type = x => Math.Abs(x) % 2 == 1;
            }
            else if (cmd == "even")
            {
                type = x => x % 2 == 0;
            }

            Console.WriteLine(string.Join(" ", range.Where(x=>type(x))));

        }
    }
}
