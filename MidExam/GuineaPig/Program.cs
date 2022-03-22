using System;

namespace GuineaPig
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            double hay = double.Parse(Console.ReadLine());
            double cover = double.Parse(Console.ReadLine());
            double pigWeight = double.Parse(Console.ReadLine());

            for (int i = 1; i <= 30; i++)
            {
                food -= 0.3;
                if (Math.Round(food, 2) <= 0 )
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
                if (i%2 == 0 )
                {
                    hay -= food * 0.05;
                    if (Math.Round(hay, 2) <= 0)
                    {
                        Console.WriteLine("Merry must go to the pet store!");
                        return;

                    }
                }
                if (i%3 == 0)
                {
                    cover -= pigWeight / 3.0;
                    if (Math.Round(cover, 2) <= 0)
                    {
                        Console.WriteLine("Merry must go to the pet store!");
                        return;

                    }
                }
            }

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hay:f2}, Cover: {cover:f2}.");

        }
    }
}
