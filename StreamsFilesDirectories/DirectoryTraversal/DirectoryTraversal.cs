namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            var extensionFile = new Dictionary<string, Dictionary<string,double>>();
            string[] filesInDir = Directory.GetFiles(inputFolderPath);
            var report = new StringBuilder();

            foreach (var file in filesInDir)
            {
                var fileInfo = new FileInfo(file);

                string fileEx = fileInfo.Extension;
                if (!extensionFile.ContainsKey(fileEx))
                {
                    extensionFile[fileEx] = new Dictionary<string, double>();
                }
                extensionFile[fileEx][fileInfo.Name] = fileInfo.Length/1024.0;
            }

            foreach (var ex in extensionFile.OrderByDescending(f=>f.Value.Count).ThenBy(n=>n.Key))
            {
                report.AppendLine($"{ex.Key}");
                foreach (var file in ex.Value.OrderBy(s=>s.Value))
                {
                    report.AppendLine($"--{file.Key} - {file.Value}kb");
                }
            }

            return report.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(path, textContent);
        }
    }
}
