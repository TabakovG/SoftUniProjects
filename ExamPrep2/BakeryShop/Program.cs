using System;
using System.Collections.Generic;
using System.Linq;

namespace BakeryShop
{
    internal class Program
    {
        static void Main()
        {
            Queue<double> water = new Queue<double>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                );
            Stack<double> flour = new Stack<double>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                );

            Dictionary<string, double> products = new Dictionary<string, double>()
            {
                {"Croissant",0 },
                {"Muffin",0 },
                {"Baguette",0 },
                {"Bagel",0 }
            };

            while (water.Count > 0 && flour.Count > 0)
            {
                double currentWater = water.Dequeue();
                double currentFlour = flour.Pop();

                if (currentWater == currentFlour)
                    products["Croissant"]++;
                else if (currentWater == 0.4 * (currentWater + currentFlour))
                    products["Muffin"]++;
                else if (currentWater == 0.3 * (currentWater + currentFlour))
                    products["Baguette"]++;
                else if (currentWater == 0.2 * (currentWater + currentFlour))
                    products["Bagel"]++;
                else
                {
                    var flourLeft = currentFlour - currentWater;
                    products["Croissant"]++;
                    flour.Push(flourLeft);
                }
            }

            foreach (var item in products.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
            {
                if (item.Value > 0)
                    Console.WriteLine($"{item.Key}: {item.Value}");
            }
            if (water.Count == 0)
                Console.WriteLine("Water left: None");
            else
                Console.WriteLine($"Water left: {string.Join(", ", water)}");
            if (flour.Count == 0)
                Console.WriteLine("Flour left: None");
            else
                Console.WriteLine($"Flour left: {string.Join(", ", flour)}");
        }
    }
}
