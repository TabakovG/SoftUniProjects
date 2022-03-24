using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace Rage_Quit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string pattern = @"([\D]+\d+)+?";
            string patternForDistinct = @"\D";

            MatchCollection commands = Regex.Matches(input, pattern);
            MatchCollection uniqueSimb = Regex.Matches(input, patternForDistinct);


            StringBuilder result = new StringBuilder();

            foreach (Match match in commands)
            {
                int iterations = int.Parse(Regex.Match(match.Value, @"\d+").Value);
                string strToRepeat = Regex.Match(match.Value, @"\D+").Value;

                result.Append(new StringBuilder(strToRepeat.Length * iterations).Insert(0, strToRepeat, iterations).ToString().ToUpper());
            }

            int uniqueS = result.ToString().Select(x => x.ToString().ToLower()).Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueS}");
            Console.WriteLine(result);
        }
    }
}
