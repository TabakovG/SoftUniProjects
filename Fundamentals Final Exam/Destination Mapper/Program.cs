using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string pattern = @"([\=\/])(?<location>[A-Z][A-Za-z]{2,})\1";
            MatchCollection validLocations = Regex.Matches(input, pattern);
            List<string> validL = new List<string>();
            int travelPoints = 0;

            foreach (Match match in validLocations)
            {
                validL.Add(match.Groups["location"].Value);
                travelPoints += match.Groups["location"].Value.Length;

            }

            Console.WriteLine($"Destinations: {string.Join(", ", validL)}");
            Console.WriteLine($"Travel Points: {travelPoints}");

        }
    }
}
