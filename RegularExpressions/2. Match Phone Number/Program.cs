using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"( |)\+359( |-)2\2\d{3}\2\d{4}\b";

            MatchCollection result = Regex.Matches(input, pattern);
            List<string> matches = result.Select(x => x.Value.Trim()).ToList();

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
