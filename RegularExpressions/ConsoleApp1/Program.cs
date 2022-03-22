using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> results = new List<string>();
            double profits = 0;

            while (input != "end of shift")
            {

                string pattern = @".*%(?<student>[A-Z][a-z]+)%.*<(?<product>\w+)>.*\|(?<count>\d+)\|\D*(?<price>\d+(\.|)\d*)\$.*";
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    double totalPrice = int.Parse(match.Groups["count"].Value) * double.Parse(match.Groups["price"].Value);
                    profits += totalPrice;
                    results.Add($"{match.Groups["student"].Value}: {match.Groups["product"].Value} - {totalPrice:f2}");

                }
                input = Console.ReadLine();
            }
            if (results.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, results));
            }
            Console.WriteLine($"Total income: {profits:f2}");
        }
    }
}
