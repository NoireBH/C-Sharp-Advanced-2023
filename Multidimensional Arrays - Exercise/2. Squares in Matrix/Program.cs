using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowAndCol = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int numberOfRows = rowAndCol[0];
            int numberOfCols = rowAndCol[1];
            char[,] matrix = new char[numberOfRows, numberOfCols];
            int same2x2SquareCount = 0;

            for (int i = 0; i < numberOfRows; i++)
            {
                char[] characters = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();

                for (int j = 0; j < numberOfCols; j++)
                {
                    matrix[i, j] = characters[j];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1]
                        && matrix[row + 1, col] == matrix[row + 1, col + 1]
                       &&
                        matrix[row, col] == matrix[row + 1, col + 1]
                        &&
                        matrix[row, col + 1] == matrix[row + 1, col + 1])
                    {
                        same2x2SquareCount++;
                    }
                }
            }

            Console.WriteLine(same2x2SquareCount);

        }
    }
}
