using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b([A-Z][a-z]{1,}) [A-Z][a-z]{1,}\b";

            Regex regex = new Regex(pattern);
            MatchCollection names =  regex.Matches(input);

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
