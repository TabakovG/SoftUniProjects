using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Post_Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|").ToArray();

            string firstPart = input[0];
            string secondPart = input[1];
            string thirdPart = input[2];

            string patternFirstP = @"([\$\#\%\*\&])(?<letters>[A-Z]+)\1";
            string patternSecondP = @"\d+\:\d{2}";

            string[] words = thirdPart.Split();


            Match capitalLetters = Regex.Match(firstPart, patternFirstP);
            MatchCollection wordsData = Regex.Matches(secondPart, patternSecondP);

            foreach (char ch in capitalLetters.Groups["letters"].Value)
            {
                int asciiValue = ch;

                foreach (Match item in wordsData)
                {
                    if (int.Parse(item.Value.Split(":")[0]) == asciiValue)
                    {
                        int wordLength = int.Parse(item.Value.Split(":")[1])+1;

                        string[] filteredWords = words.Where(word => word.Length == wordLength && word[0]==ch).ToArray();

                        if (filteredWords.Length > 0)
                        {
                            Console.WriteLine(filteredWords[0]);
                            break;
                        }
                    }
                }
            }

            
        }
    }
}
