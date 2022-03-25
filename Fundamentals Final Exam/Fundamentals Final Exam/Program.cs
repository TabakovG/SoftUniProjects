using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Fundamentals_Final_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string pattern = @"([|#])(?<food>[\sA-Za-z]+)\1(?<exDate>\d{2}\/\d{2}\/\d{2})\1(?<kcal>\d{1,5})\1";
            int totalKCal = 0;
            MatchCollection food = Regex.Matches(input, pattern);
            List<string> items = new List<string>();

            foreach (Match match in food)
            {
                string foodName = match.Groups["food"].Value;
                string expirationDate = match.Groups["exDate"].Value;
                string kcal = match.Groups["kcal"].Value;

                totalKCal += int.Parse(kcal);
                items.Add($"Item: {foodName}, Best before: {expirationDate}, Nutrition: {kcal}");
            }
            int days = totalKCal / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");
            if (items.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, items));
            }
        }
    }
}
