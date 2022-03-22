using System;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] vDay = new int[neighborhood.Length];
            int cupidIndex = 0;

            string command = Console.ReadLine();

            while (command != "Love!")
            {
                string[] token = command.Split().ToArray();
                int jumpValue = int.Parse(token[1]);

                cupidIndex += jumpValue;
                if (cupidIndex > neighborhood.Length - 1)
                {
                    cupidIndex = 0;
                }

                neighborhood[cupidIndex] -= 2;
                if (neighborhood[cupidIndex] <= 0 && vDay[cupidIndex] != 1)
                {
                    neighborhood[cupidIndex] = 0;
                    Console.WriteLine($"Place {cupidIndex} has Valentine's day.");
                    vDay[cupidIndex] = 1;
                }
                else if (vDay[cupidIndex] == 1)
                {
                    Console.WriteLine($"Place {cupidIndex} already had Valentine's day.");
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {cupidIndex}.");
            if (vDay.Contains(0))
            {
                int counter = 0;
                foreach (int item in vDay)
                {
                    if (item == 0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"Cupid has failed {counter} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
    }
}
