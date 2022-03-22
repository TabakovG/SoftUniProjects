using System;
using System.Linq;

namespace _4._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            Console.WriteLine(string.Join(Environment.NewLine, arr.Where(x => x.Length % 2 == 0)));
        }
    }
}
