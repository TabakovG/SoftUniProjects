namespace LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            int lineNum = 1;

            string[] text = File.ReadAllText(inputFilePath).Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
            List<string> output = new List<string>();

            foreach (string line in text)
            {
                int lettersNum = 0;
                int marksNum = 0;

                foreach (char ch in line)
                {
                    if (char.IsLetterOrDigit(ch))
                    {
                        lettersNum++;
                    }
                    else if (ch != ' ')
                    {
                        marksNum++;
                    }
                }

                output.Add($"Line {lineNum}: {line} ({lettersNum})({marksNum})");
                lineNum++;
            }

            File.WriteAllText(outputFilePath, string.Join("\r\n", output));
        }
    }
}
