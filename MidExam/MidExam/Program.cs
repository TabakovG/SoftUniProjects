using System;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal sum = 0;
            decimal tax = 0;

            while (input != "special" && input != "regular")
            {
                decimal price = decimal.Parse(input);
                if (price <= 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    sum += price;
                }
                input = Console.ReadLine();
            }

            tax = (decimal)0.2 * sum;

            if (sum == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {sum:f2}$");
            Console.WriteLine($"Taxes: {tax:f2}$");
            if (input == "special")
            {
                tax = (decimal)0.9 * tax;
                sum = (decimal)0.9 * sum;
            }
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {sum + tax:f2}$");
        }
    }
}
