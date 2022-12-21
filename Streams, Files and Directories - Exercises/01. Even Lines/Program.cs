namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            ProcessLines(inputFilePath);
        }

        public static void ProcessLines(string inputFilePath)
        {
            using (StreamReader input = new StreamReader(inputFilePath))
            {
                int counter = 0;
                string lines = input.ReadLine();
                

                while (lines != null)
                {                   
                    if (counter % 2 == 0)
                    {   

                        lines = Replace(lines);
                        lines = Reverse(lines);
                        Console.WriteLine(lines);
                    }

                    counter++;
                    lines = input.ReadLine();
                }
            }
        }
        public static string Replace(string lines)
        {
            lines = lines.Replace("-", "@")
                .Replace(",", "@")
                .Replace(".", "@")
                .Replace("!", "@")
                .Replace("?", "@");
            return lines;

        }
        public static string Reverse(string lines)
        {
            return string.Join(" ", lines.Split().Reverse());
        }
    }
}
