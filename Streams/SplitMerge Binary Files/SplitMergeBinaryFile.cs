namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            var fSize = new FileInfo(sourceFilePath).Length;
            long bufferSize = fSize / 2;
            if (fSize % 2 == 1)
            {
                bufferSize++;
            }
            using var stream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read);
            byte[] buf = new byte[bufferSize];
            using var writer = new FileStream(partOneFilePath, FileMode.Create, FileAccess.Write);
            stream.Read(buf);
            writer.Write(buf);
            using var writer2 = new FileStream(partTwoFilePath, FileMode.Create, FileAccess.Write);
            stream.Read(buf);
            writer2.Write(buf);

        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            byte[] part1 = File.ReadAllBytes(partOneFilePath);
            byte[] part2 = File.ReadAllBytes(partTwoFilePath);

            using var joined = new FileStream(joinedFilePath, FileMode.Append, FileAccess.Write);
            joined.Write(part1);
            joined.Write(part2);
        }
    }
}