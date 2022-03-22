using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            char[] ch = { 's', 't', 'a', 'r' }; 
            List<string> attackedPlanets = new List<string>();
            List<string> destrPlanets = new List<string>();


            for (int i = 0; i < num; i++)
            {

                string input = Console.ReadLine();

                int lettersCount = input.Where(x => char.IsLetter(x) && ch.Contains(char.ToLower(x))).Count();

                string decriptedMsg = string.Empty;
                foreach (char c in input)
                {
                    decriptedMsg += (char)(c - lettersCount);
                }

                string pattern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:>]*?\:(?<population>\d+)[^\@\-\!\:>]*?\!(?<attack>[A|D])\![^\@\-\!\:>]*?\-\>(?<soldiers>\d+)";
                Match msg = Regex.Match(decriptedMsg, pattern);

                if (msg.Success)
                {
                    if (msg.Groups["attack"].Value == "A")
                    {
                        attackedPlanets.Insert(0, msg.Groups["planet"].Value);
                    }
                    else
                    {
                        destrPlanets.Insert(0, msg.Groups["planet"].Value);

                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count > 0)
            {
                Console.WriteLine("-> " + string.Join($"{Environment.NewLine}-> ", attackedPlanets.OrderBy(x=>x)));
            }
            Console.WriteLine($"Destroyed planets: {destrPlanets.Count}");
            if (destrPlanets.Count > 0)
            {
                Console.WriteLine("-> " + string.Join($"{Environment.NewLine}-> ", destrPlanets.OrderBy(x => x)));
            }
        }
    }
}
