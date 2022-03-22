using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            SortedDictionary<string, Dictionary<double, double>> demonsList = new SortedDictionary<string, Dictionary<double, double>>();
            string pattern = @"(?<demon>[^\s,]+)";

            MatchCollection demons = Regex.Matches(input, pattern);

            if (demons.Count > 0)
            {
                foreach (Match item in demons)
                {
                    demonsList[item.Value] = new Dictionary<double, double>();

                    string healthPattern = @"(?<health>[^\d\+\-\*\/\.])";
                    int sumChar = 0;

                    MatchCollection healthChars = Regex.Matches(item.Value, healthPattern);
                    if (healthChars.Count > 0)
                    {
                        foreach (char ch in string.Join("", healthChars))
                        {
                            sumChar += ch;
                        }
                    }

                    string damagePattern = @"(?<damage>\-?\d+(\.\d+)?)";
                    double sumNum = 0;

                    MatchCollection damageNums = Regex.Matches(item.Value, damagePattern);

                    if (damageNums.Count > 0)
                    {
                        foreach (Match num in damageNums)
                        {
                            sumNum += double.Parse(num.Groups["damage"].Value);
                        }
                    }
                    foreach (char c in item.Value)
                    {
                        if (c == '*')
                        {
                            sumNum *= 2;
                        }
                        else if (c == '/')
                        {
                            sumNum /= 2;
                        }
                    }

                    demonsList[item.Value][sumChar] = sumNum;
                }
                foreach (var dem in demonsList)
                {
                    foreach (var stat in dem.Value)
                    {
                        Console.WriteLine($"{dem.Key} - {stat.Key} health, {stat.Value:f2} damage");
                    }
                }
            }

        }
    }
}
