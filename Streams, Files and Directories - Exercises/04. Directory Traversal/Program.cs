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
          string[]  files = Directory.GetFiles(inputFolderPath);

            var extensionsInfo = new Dictionary<string, List<FileInfo>>();

            foreach (var file in files)
            {
                FileInfo fileinfo = new FileInfo(file);
                string extension = fileinfo.Extension;

                if (!extensionsInfo.ContainsKey(extension))
                {
                    extensionsInfo.Add(extension, new List<FileInfo>());

                }
                extensionsInfo[extension].Add(fileinfo);

            }


            StringBuilder sb = new StringBuilder();

            foreach (var entry in extensionsInfo.OrderByDescending(entry => entry.Value.Count)
                .ThenBy(entry => entry.Key))
            {   
                string extension = entry.Key;
                sb.AppendLine(extension);

                List<FileInfo> fileinfo = entry.Value;
                fileinfo.OrderByDescending(file => file.Length);

                foreach (var file in fileinfo)
                {
                    sb.AppendLine($"-- {file.Name} - {file.Length / 1024:f3}kb");
                    
                }
            }

            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(path, textContent);
            
        }
    }
}
