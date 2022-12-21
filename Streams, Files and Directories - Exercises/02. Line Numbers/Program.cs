namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            using(StreamReader reader = new StreamReader(inputFilePath))
            {
                using(StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int count = 0;
                    string[] lines = File.ReadAllLines(inputFilePath);

                    foreach (var line in lines)
                    {
                        count++;
                        int countLetters = line.Count(char.IsLetter);
                        int countSymbol = line.Count(char.IsPunctuation);

                        string modifiedLine = $"Line {count}: {line} ({countLetters})({countSymbol})";
                        writer.WriteLine(modifiedLine);

                    }

                }
            }
        }
    }
}
