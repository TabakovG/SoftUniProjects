namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);

        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            var input = new StreamReader(wordsFilePath);
            using (input)
            {
                string[] wrds = input.ReadToEnd().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in wrds)
                {
                    if (!wordCounts.ContainsKey(item.ToLower()))
                    {
                        wordCounts[item.ToLower()] = 0;
                    }
                }

            }

            var text = new StreamReader(textFilePath);
            using (text)
            {
                while (true)
                {
                    var line = text.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    line = string.Join("", line.Where(c => char.IsLetterOrDigit(c) || c == ' '));
                    string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (var w in words)
                    {
                        if (wordCounts.ContainsKey(w.ToLower()))
                        {
                            wordCounts[w.ToLower()]++;
                        }
                    }
                }
            }

            var writer = new StreamWriter(outputFilePath);
            using (writer)
            {
                foreach (var word in wordCounts.OrderByDescending(x=>x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }

        }
    }
}
