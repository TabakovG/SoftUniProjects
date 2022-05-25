using System;
using System.Linq;

namespace Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", 
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray()
                .OrderByDescending(n=>n)
                .Take(3)));
        }
    }
}
