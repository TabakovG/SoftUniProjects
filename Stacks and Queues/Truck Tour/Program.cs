using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();
            for (int i = 0; i < n; i++)
            {
                int[] pumpData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumps.Enqueue(pumpData);

            }

            int truckFuel = 0;


            for (int j = 0; j < n; j++)
            {
                truckFuel = pumps.Peek()[0];
                while (truckFuel >= pumps.Peek()[1])
                {
                    truckFuel -= pumps.Peek()[1];
                    pumps.Dequeue();
                    if (pumps.Count == 0)
                    {
                        Console.WriteLine(j);
                        return;
                    }
                    truckFuel += pumps.Peek()[0];
                }
                pumps.Enqueue(pumps.Dequeue());
            }
        }
    }
}
