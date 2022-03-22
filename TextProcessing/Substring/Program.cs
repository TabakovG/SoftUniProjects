using System;

namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string toRemove = Console.ReadLine();
            string toCompare = Console.ReadLine();

            while (toCompare.Contains(toRemove))
            {
                int indexSt = toCompare.IndexOf(toRemove);
                toCompare = toCompare.Remove(indexSt, toRemove.Length);
            }
            Console.WriteLine(toCompare);
        }
    }
}
