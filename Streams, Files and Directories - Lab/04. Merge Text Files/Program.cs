namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            var firstReader = new StreamReader(firstInputFilePath);
            var secondReader = new StreamReader(secondInputFilePath);
            var writer = new StreamWriter(outputFilePath);

            using (firstReader)
            {
                

                using (secondReader)
                {
                    

                    using (writer)
                    {
                        while (!firstReader.EndOfStream || !secondReader.EndOfStream)
                        {
                            if (!firstReader.EndOfStream)
                                writer.WriteLine(firstReader.ReadLine());
                            
                            if (!secondReader.EndOfStream)
                                writer.WriteLine(secondReader.ReadLine());
                            
                        }
                    }
                }
            }
        }
    }
}
