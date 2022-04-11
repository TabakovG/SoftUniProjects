using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int rackCapacity = int.Parse(Console.ReadLine());
            int currentRack = 0;
            int racksUsed = 1;

            while (clothes.Any())
            {
                if (currentRack+clothes.Peek() <= rackCapacity)
                {
                    currentRack += clothes.Pop();
                }
                else
                {
                    racksUsed++;
                    currentRack = 0;
                    currentRack += clothes.Pop();
                }
            }

            Console.WriteLine(racksUsed);
        }
    }
}
