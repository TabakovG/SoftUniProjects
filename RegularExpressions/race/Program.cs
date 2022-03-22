using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] racers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> results = new Dictionary<string, int>();
            foreach (string racer in racers)
            {
                results[racer] = 0;
            }
            string input = Console.ReadLine();

            while (input != "end of race")
            {

                string namePattern = $"[A-Za-z]";

                MatchCollection nameLetters = Regex.Matches(input, namePattern);
                string checkName = string.Join("", nameLetters);

                if (racers.Contains(checkName))
                {
                    string distancePattern = @"\d";

                    MatchCollection distance = Regex.Matches(input, distancePattern);
                    int totalDistance = 0;
                    foreach (Match match in distance)
                    {
                        totalDistance += int.Parse(match.Value);
                    }
                    results[checkName] += totalDistance;
                }

                input = Console.ReadLine();
            }

            List<string> winers = new List<string>();
            foreach (var racer in results.OrderByDescending(x => x.Value))
            { 
                winers.Add(racer.Key);
            }
            Console.WriteLine($"1st place: {winers[0]}");
            Console.WriteLine($"2nd place: {winers[1]}");
            Console.WriteLine($"3rd place: {winers[2]}");
        }
    }
}
