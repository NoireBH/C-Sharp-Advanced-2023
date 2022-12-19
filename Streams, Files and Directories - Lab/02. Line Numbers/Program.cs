namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"input.txt";
            string outputPath = @"output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            var reader = new StreamReader(inputFilePath);
            using (reader)
            {
                var writer = new StreamWriter(outputFilePath);
                using (writer)
                {
                    int lineNumber = 1;
                    string line;

                    while ((line = reader.ReadLine())!= null)
                    {
                        writer.WriteLine($"{lineNumber}.  {line}");
                        lineNumber++;
                    }
                }
            }
        }
    }
}
