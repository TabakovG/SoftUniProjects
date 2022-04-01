using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Mirror_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string pattern = @"([@#])(?<first>[a-zA-Z]{3,})\1\1(?<second>[a-zA-Z]{3,})\1";
            List<string> validMatches = new List<string>();

            MatchCollection matchCollection = Regex.Matches(str, pattern);

            if (matchCollection.Count <= 0)
            {
                Console.WriteLine($"No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matchCollection.Count} word pairs found!");

                foreach (Match item in matchCollection)
                {
                    if (item.Groups["first"].Value == String.Join("", item.Groups["second"].Value.Reverse()))
                    {
                        validMatches.Add($"{item.Groups["first"].Value} <=> {item.Groups["second"].Value}");
                    }

                }

            }

            if (validMatches.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"The mirror words are:");
                Console.Write(string.Join(", ", validMatches));
            }
        }
    }
}
