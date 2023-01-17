using System;
using System.Linq;

namespace _06._Road_Reconstruction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] rowAndCol = Console.ReadLine().Split(",")
                .Select(int.Parse).ToArray();

            int row = rowAndCol[0];
            int col = rowAndCol[1];

            int[,] matrix = new int[row, col];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] numbers = Console.ReadLine().Split(", ")
                    .Select(int.Parse).ToArray();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r,c] = numbers[c];
                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int r = 0; r < matrix.GetLength(0) - 1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 1; c++)
                {
                    
                    int currentSum = matrix[r, c] + matrix[r, c + 1] 
                        + matrix[r + 1, c] + matrix[r + 1, c + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = r;
                        maxCol = c;
                    }
                }
            }

            Console.WriteLine($"{ matrix[maxRow,maxCol]} {matrix[maxRow,maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
            Console.WriteLine(maxSum);


        }
    }
}
