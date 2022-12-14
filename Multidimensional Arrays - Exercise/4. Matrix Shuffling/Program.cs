using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowAndCol = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int numberOfRows = rowAndCol[0];
            int numberOfCols = rowAndCol[1];
            string[,] matrix = new string[numberOfRows, numberOfCols];
            FillMatrix(matrix);

            string input;
            while ((input = Console.ReadLine())!= "END")
            {
                string[] cmd = input.Split();
                string command = cmd[0];

                if (command == "swap" && cmd.Length == 5)
                {
                    int row1 = int.Parse(cmd[1]);
                    int col1 = int.Parse(cmd[2]);
                    int row2 = int.Parse(cmd[3]);
                    int col2 = int.Parse(cmd[4]);

                    if (row1 >= 0 && row1 < matrix.GetLength(0)  && col1 >= 0 && col1 < matrix.GetLength(1)
                        && row2 >= 0 && row2 < matrix.GetLength(0) && col2 >=0 && col2 < matrix.GetLength(1))
                    {   
                        string firstElement = matrix[row1, col1];
                        string secondElement = matrix[row2, col2];
                        matrix[row1, col1] = secondElement;
                        matrix[row2, col2] = firstElement;
                        PrintMatrix(matrix);
                    }

                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }

                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

            

        }
        public static void FillMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
        }

        public static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
