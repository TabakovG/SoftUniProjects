namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using var reader = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read);
            using var writer = new FileStream(outputFilePath, FileMode.Append, FileAccess.Write);

            byte[] buffer = new byte[2048];
            int dataSize = reader.Read(buffer);

            while (dataSize > 0)
            {
                writer.Write(buffer);
                dataSize = reader.Read(buffer);
            }
        }
    }
}
