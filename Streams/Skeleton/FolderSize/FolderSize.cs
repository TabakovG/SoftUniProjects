﻿namespace FolderSize
{
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            long totalSize = 0;
            string[] files = Directory.GetFiles(folderPath);
            foreach (var file in files)
            {
                totalSize += new FileInfo(file).Length;
            }
            string[] folders = Directory.GetDirectories(folderPath);
            foreach (var folder in folders)
            {
                string[] subFiles = Directory.GetFiles(folder);
                foreach (var sFile in subFiles)
                {
                    totalSize += new FileInfo(sFile).Length;
                }
            }
            using var writer = new StreamWriter(outputFilePath);
            writer.Write(totalSize/1024.0);
        }
    }
}
