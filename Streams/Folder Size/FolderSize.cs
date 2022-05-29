namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            double totalSize = GetFolderSize(folderPath)/1024.0;
            using var writer = new StreamWriter(outputPath);
            writer.Write(totalSize);
        }

        static long GetFolderSize(string folderPath)
        {
            long totalSize = 0;
            string[] files = Directory.GetFiles(folderPath);
            foreach (var file in files)
            {
                totalSize += new FileInfo(file).Length;
            }
            string[] folders = Directory.GetDirectories(folderPath);
            foreach (var subfolder in folders)
            {
                totalSize += GetFolderSize(subfolder);
            }
            return totalSize;
        }
    }
}
