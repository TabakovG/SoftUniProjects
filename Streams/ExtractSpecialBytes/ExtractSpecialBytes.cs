namespace ExtractBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            using var specialBytes = new StreamReader(bytesFilePath);
            List<string> bList = new List<string>();

            while (!specialBytes.EndOfStream)
            {
                bList.Add(specialBytes.ReadLine());
            }

            using var png = new FileStream(binaryFilePath,FileMode.Open, FileAccess.Read);
            byte[] pngBytes = new byte[png.Length];

            png.Read(pngBytes, 0, pngBytes.Length);

            using var output = new StreamWriter(outputPath);

            foreach (var item in pngBytes)
            {
                if (bList.Contains(item.ToString()))
                {
                    output.Write(item.ToString());
                }
            }
        }
    }
}
