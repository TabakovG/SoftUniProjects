using System;
using System.Linq;

namespace Froggy
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var lake = new Lake(input);
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
