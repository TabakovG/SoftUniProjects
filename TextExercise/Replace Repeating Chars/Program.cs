using System;
using System.Collections.Generic;
using System.Linq;

namespace Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> input = Console.ReadLine().ToList();

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i-1])
                {
                    input.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join("", input));
        }
    }
}
