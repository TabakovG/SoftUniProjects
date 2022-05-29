using System;

namespace OddLines
{
    using System.IO;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            var input = new StreamReader(inputFilePath);
            int lineNum = 0;
            using (input)
            {
                var output = new StreamWriter(outputFilePath);
                using (output)
                {
                    string line;
                    while ((line = input.ReadLine()) != null)
                    {
                        if (lineNum % 2 == 1)
                        {
                            output.WriteLine(line);
                        }
                        lineNum++;
                    }
                }
            }
        }
    }
}
