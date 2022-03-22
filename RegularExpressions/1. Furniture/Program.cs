using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"^>>(?<fName>[A-Za-z]+)<<(?<price>\d+\.*\d*)!(?<quantity>\d+)\b";
            double sum = 0;
            List<string> items = new List<string>();

            while (input != "Purchase")
            {
                Match item = Regex.Match(input, pattern);
                if (item.Captures.Count > 0)
                {
                    items.Add(item.Groups["fName"].ToString());
                    sum += double.Parse(item.Groups["price"].ToString()) * int.Parse(item.Groups["quantity"].ToString());
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            if (items.Count > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, items));
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
