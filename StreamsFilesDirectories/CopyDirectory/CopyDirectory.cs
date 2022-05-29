namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            var dirInfo = new DirectoryInfo(inputPath);
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, recursive: true);
            }

            Directory.CreateDirectory(outputPath + "/" + dirInfo.Name);
            foreach (var file in Directory.GetFiles(inputPath))
            {
                var fileInfo = new FileInfo(file);
                var destination = outputPath + "/" + dirInfo.Name + "/" + fileInfo.Name;
                File.Copy(file, destination);
            }

        }
    }
}
