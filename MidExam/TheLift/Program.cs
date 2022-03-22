using System;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int queue = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < lift.Length; i++)
            {
                while (lift[i] < 4 && queue > 0)
                {
                    lift[i]++;
                    queue--;
                }
                if (queue == 0)
                {
                    break;
                }
            }

            if (queue == 0)
            {
                for (int j = 0; j < lift.Length; j++)
                {
                    if (lift[j]!= 4)
                    {
                        Console.WriteLine($"The lift has empty spots!");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"There isn't enough space! {queue} people in a queue!");
            }
            Console.WriteLine(string.Join(" ", lift));

        }

    }
}

