namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            var file1 = new StreamReader(firstInputFilePath);
            using (file1)
            {
                var file2 = new StreamReader(secondInputFilePath);
                using (file2)
                {
                    var output = new StreamWriter(outputFilePath);
                    using (output)
                    {
                        while (true)
                        {
                            string line1 = file1.ReadLine();
                            string line2 = file2.ReadLine();
                            if (line1 == null && line2 == null)
                            { 
                                break;
                            }
                            if (line1 != null) 
                            {
                            output.WriteLine(line1);
                            }
                            if (line2 != null)
                            {
                                output.WriteLine(line2);
                            }

                        }
                    }
                }
            }


        }
    }
}
