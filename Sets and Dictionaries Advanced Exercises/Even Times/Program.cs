using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Times
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, int> map = new Dictionary<string, int>();

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                if (!map.ContainsKey(input))
                {
                    map[input] = 0;
                }
                map[input]++;
            }

            foreach (var item in map.Where(x => x.Value % 2 == 0))
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
