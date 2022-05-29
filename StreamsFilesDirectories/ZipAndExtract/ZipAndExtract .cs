namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFile = @"..\..\..\copyMe.png";
            string zipArchiveFile = @"..\..\..\archive.zip";
            string extractedFile = @"..\..\..\extracted.png";

            ZipFileToArchive(inputFile, zipArchiveFile);

            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            var file = new FileInfo(inputFilePath);
            string tempDir = $"{file.Directory}/temp";
            Directory.CreateDirectory(tempDir);
            File.Copy(inputFilePath, $"{tempDir}/{file.Name}");
            if (File.Exists(zipArchiveFilePath))
            {
                File.Delete(zipArchiveFilePath);
            }
            ZipFile.CreateFromDirectory(tempDir, zipArchiveFilePath);
            Directory.Delete(tempDir, true);
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            var zipDir = new FileInfo(zipArchiveFilePath);
            string tempDirExt = $"{zipDir.Directory}/tempExtract";
            Directory.CreateDirectory(tempDirExt);
            ZipFile.ExtractToDirectory(zipArchiveFilePath, tempDirExt, true);
            File.Move($"{tempDirExt}/{fileName}", outputFilePath, true);
            Directory.Delete(tempDirExt, true);
        }
    }
}
