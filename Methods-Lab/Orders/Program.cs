using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quntity = double.Parse(Console.ReadLine());

            const double COFFEE = 1.50;
            const double WATER = 1.00;
            const double COKE = 1.40;
            const double SNACKS = 2.00;

            double price = 0;

            switch (product)
            {
                case "coffee":
                    price = COFFEE;
                    break;
                case "water":
                    price = WATER;
                    break;
                case "coke":
                    price = COKE;
                    break;
                case "snacks":
                    price = SNACKS;
                    break;

            }

            Order(price, quntity);

        }

        static void Order(double price, double quantity) 
        {
            Console.WriteLine($"{price * quantity:f2}"); ;
        }
    }
}
