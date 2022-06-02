using System;
using System.Linq;

namespace _1._Action_Point
{
    internal class Action_Point
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            Action<string> printName = x => Console.WriteLine(x);

            foreach (var item in input)
            {
                printName(item);
            }
        }
    }
}
