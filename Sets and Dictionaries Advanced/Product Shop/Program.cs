using System;
using System.Collections.Generic;

namespace Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shopAndProduct = new SortedDictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Revision")
                {
                    PrintResult(shopAndProduct);
                    break;
                }
                string[] cmd = command.Split(", ");
                string shopName = cmd[0];
                string product = cmd[1];
                double price = double.Parse(cmd[2]);

                if (!shopAndProduct.ContainsKey(shopName))
                {
                    shopAndProduct[shopName] = new Dictionary<string, double>();
                }
                shopAndProduct[shopName][product] = price;

            }
        }

        private static void PrintResult(SortedDictionary<string, Dictionary<string, double>> shopAndProduct)
        {
            foreach (var productAndPrice in shopAndProduct)
            {
                Console.WriteLine($"{productAndPrice.Key}->");
                foreach (var item in productAndPrice.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
