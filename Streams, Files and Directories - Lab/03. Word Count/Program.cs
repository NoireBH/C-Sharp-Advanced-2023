using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader(wordsFilePath))
            {
                string[] words = reader.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    output.Add(word.ToLower(), 0);
                }

                using (StreamReader readInput = new StreamReader(textFilePath))
                {
                    string line = readInput.ReadToEnd();

                    string patternt = @"[A-Za-z]+";

                    foreach (Match m in Regex.Matches(line, patternt))
                    {
                        string currentWord = m.Value.ToLower();

                        for (int i = 0; i < words.Length; i++)
                        {
                            if (currentWord == words[i])
                            {
                                output[currentWord]++;
                            }
                        }
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var word in output.OrderByDescending(w => w.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
