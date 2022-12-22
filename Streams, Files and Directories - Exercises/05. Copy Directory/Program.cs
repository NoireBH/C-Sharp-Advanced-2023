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
           
            string[] files = Directory.GetFiles(inputPath);

            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file);
                var pathname = Path.GetFullPath(file);

                File.Copy(pathname, outputPath + "//" + fileName);
            }
        }
    }
}
