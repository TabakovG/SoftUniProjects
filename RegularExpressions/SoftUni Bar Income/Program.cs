using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> results = new List<string>();
            double profits = 0;
            string customerPattern = @"%(?<customer>[A-Z][a-z]+)%";
            string productPattern = @"<(?<product>\w+)>";
            string countPattern = @"\|(?<count>\d+)\|";
            string pricePattern = @"(?<price>(\d+\.{1}){0,1}\d+)\$";

            while (input != "end of shift")
            {
                bool isValid = Regex.IsMatch(input, customerPattern) && Regex.IsMatch(input, productPattern) && Regex.IsMatch(input, countPattern) && Regex.IsMatch(input, pricePattern);

                if (isValid)
                {
                    Match customerName = Regex.Match(input, customerPattern);
                    Match productName = Regex.Match(input, productPattern);
                    Match price = Regex.Match(input, pricePattern);
                    Match count = Regex.Match(input, countPattern);

                    string data = $"{customerName.Groups["customer"].Value}: {productName.Groups["product"].Value} - {double.Parse(price.Groups["price"].Value) * double.Parse(count.Groups["count"].Value):f2}";
                    profits += double.Parse(price.Groups["price"].Value) * double.Parse(count.Groups["count"].Value);
                    results.Add(data);
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
