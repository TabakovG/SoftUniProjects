using System;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cities = int.Parse(Console.ReadLine());
            decimal ernings = 0m;

            for (int i = 1; i <= cities; i++)
            {
                string cityName = Console.ReadLine();
                decimal income = decimal.Parse(Console.ReadLine());
                decimal expences = decimal.Parse(Console.ReadLine());


                if (i%3 == 0 && i%5 != 0)
                {
                    expences *= 1.5m;
                }
                if (i%5 == 0)
                {
                    income *= 0.9m;
                }

                ernings += income - expences;
                Console.WriteLine($"In {cityName} Burger Bus earned {income - expences:f2} leva.");
            }

            Console.WriteLine($"Burger Bus total profit: {ernings:f2} leva.");
        }
    }
}
