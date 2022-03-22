using System;
using System.Text.RegularExpressions;

namespace More_Exercise_Regular_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\s*\,\s+";
            string winningPattern = @"([\@\#\$\^])\1{5,9}";

            string[] tickets = Regex.Split(input, pattern);

            foreach (string ticketsItem in tickets)
            {
                string checkTicket = isWinning(ticketsItem, winningPattern);

                if (ticketsItem.Length != 20)
                {
                    if (ticketsItem.Length > 0)
                    {
                        Console.WriteLine(checkTicket);
                    }
                }
                else if (checkTicket == "-1")
                {
                    Console.WriteLine($"ticket \"{ticketsItem}\" - no match");
                }
                else if (checkTicket.Contains("10"))
                {
                    Console.WriteLine($"ticket \"{ticketsItem}\" - {checkTicket} Jackpot!");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticketsItem}\" - {checkTicket}");
                }
            }

        }

        private static string isWinning(string ticketsItem, string winningPattern)
        {
            if (ticketsItem.Length != 20)
            {
                return "invalid ticket";
            }
            string left = ticketsItem.Substring(0, 10);
            string right = ticketsItem.Substring(10, 10);

            Match leftSide = Regex.Match(left, winningPattern);
            Match rightSide = Regex.Match(right, winningPattern);


            if (leftSide.Success)
            {
                char symbolLeft = leftSide.Value[0];
                if (rightSide.Success)
                {
                    char symbolRight = rightSide.Value[0];
                    if (symbolLeft == symbolRight)
                    {
                        return (leftSide.Value.Length < rightSide.Value.Length ? leftSide.Value.Length : rightSide.Value.Length).ToString() + symbolLeft;
                    }
                }
            }
            return "-1";

        }
    }
}
