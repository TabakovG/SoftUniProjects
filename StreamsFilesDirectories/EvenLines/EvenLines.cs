namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            int counter = 0;
            char[] replace = new char[] { '-', ',', '.', '!', '?' };
            using var reader = new StreamReader(inputFilePath);
            var output = new StringBuilder();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                
                if (counter % 2 == 0)
                {
                    foreach (var item in replace)
                    {
                        line = line.Replace(item, '@');
                    }
                    string[] reverse = line.Split().Reverse().ToArray();
                    output.Append(string.Join(" ", reverse) + "\r\n");
                }
                counter++;
            }
            return output.ToString();
        }
    }
}
