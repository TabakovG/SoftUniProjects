using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();  // like 1!0!!1!!!0!1
            int SequenceIndex = 0;

            int bestSequenceIndex = 0;
            int bestSequenceSum = 0;
            string bestSequence = "";
            int bestStartIndex = int.MaxValue;
            string bestMaxValue = "";


            while (input != "Clone them!")
            {
                SequenceIndex++;
                string cleanInput = ""; // remove ! => 10101
                int cuSequenceSum = 0;
                foreach (char j in input)
                {
                    if (j != '!')
                    {
                        cleanInput += j.ToString();
                        cuSequenceSum += int.Parse(j.ToString());
                    }
                }

                string[] intDNASequence = cleanInput.Split('0').ToArray(); // like: "" 1 "" 11  or  1 "" 11 
                string maxValue = intDNASequence.Max();
                int startIndex = Array.IndexOf(intDNASequence,intDNASequence.Max());
                if (intDNASequence[0] == "1")
                {
                    startIndex++;
                }

                if (maxValue.Length > bestMaxValue.Length || (maxValue.Length == bestMaxValue.Length && startIndex < bestStartIndex) || (maxValue.Length == bestMaxValue.Length && startIndex == bestStartIndex && cuSequenceSum > bestSequenceSum))
                {
                    
                   bestSequenceIndex = SequenceIndex;
                   bestStartIndex = startIndex;
                   bestSequenceSum = cuSequenceSum;
                   bestSequence = "";
                    foreach (var item in cleanInput)
                    {
                        bestSequence += item.ToString() + " ";
                    }
                   bestMaxValue = maxValue;
                    
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine($"{bestSequence}");
        }
    }
}
