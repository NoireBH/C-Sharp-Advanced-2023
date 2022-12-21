namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (FileStream sourceImage = new FileStream(sourceFilePath, FileMode.Open))
            using (var part1Output = new FileStream(partOneFilePath, FileMode.Create))
            using (var part2Output = new FileStream(partTwoFilePath, FileMode.Create))
            {
                byte[] bufferFirstBytes = new byte[sourceImage.Length /2 + 1];

                sourceImage.Read(bufferFirstBytes, 0, bufferFirstBytes.Length);

                part1Output.Write(bufferFirstBytes, 0, bufferFirstBytes.Length);

                byte[] bufferSecondBytes = new byte[sourceImage.Length / 2];

                sourceImage.Read(bufferSecondBytes, 0, bufferSecondBytes.Length);

                part2Output.Write(bufferSecondBytes, 0, bufferSecondBytes.Length);


            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (var joinedFiles = new FileStream(joinedFilePath, FileMode.Create))
            {
                using (var fileOne = new FileStream(partOneFilePath, FileMode.Open))
                {
                  byte[] firstBytes = new byte[fileOne.Length];
                    joinedFiles.Write(firstBytes);
                }

                using (var fileTwo = new FileStream(partTwoFilePath, FileMode.Open))
                {
                   byte[] secondBytes = new byte[fileTwo.Length];
                    joinedFiles.Write(secondBytes, 0, secondBytes.Length);
                }
            }
        }
    }
}