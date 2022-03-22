using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(">>", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            double totalTaxes = 0;

            foreach (string item in input)
            {
                List<string> token = item
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string carType = token[0];
                int years = int.Parse(token[1]);
                int milage = int.Parse(token[2]);

                double tax = 0;
                bool isValidType = true;

                switch (carType)
                {
                    case "family":
                        tax = 50;
                        tax -= 5 * years;
                        tax += 12 * (milage / 3000);
                        totalTaxes += tax;

                        break;
                    case "heavyDuty":
                        tax = 80;
                        tax -= 8 * years;
                        tax += 14 * (milage / 9000);
                        totalTaxes += tax;

                        break;
                    case "sports":
                        tax = 100;
                        tax -= 9 * years;
                        tax += 18 * (milage / 2000);
                        totalTaxes += tax;

                        break;
                    default:
                        Console.WriteLine("Invalid car type.");
                        isValidType = false;
                        break;
                }
                if (isValidType == true)
                {
                    Console.WriteLine($"A {carType} car will pay {tax:f2} euros in taxes.");
                }
            }
            Console.WriteLine($"The National Revenue Agency will collect {totalTaxes:f2} euros in taxes.");
        }
    }
}
