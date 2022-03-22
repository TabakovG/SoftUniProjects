using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string text = Console.ReadLine();

            int wonBattles = 0;

            while (text != "End of battle")
            {
                int distance = int.Parse(text);

                if (energy > distance)
                {
                    energy -= distance;
                    wonBattles++;
                    if (wonBattles % 3 == 0)
                    {
                        energy += wonBattles;
                    }
                }
                else if (energy == distance)
                {
                    energy = 0;
                    wonBattles++;
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    return;

                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    return;
                }


                text = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
        }
    }
}
