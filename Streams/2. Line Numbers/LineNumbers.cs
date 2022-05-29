namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            var input = new StreamReader(inputFilePath);
            using (input)
            {
                int num = 1;
                string line;
                var output = new StreamWriter(outputFilePath);
                using (output)
                {
                    while ((line = input.ReadLine()) != null)
                    {
                        output.WriteLine($"{num}. {line}");
                        num++;
                    }
                }
            }
        }
    }
}
