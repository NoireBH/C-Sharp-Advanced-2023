using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
            int primarySum = 0;
            int secondarySum = 0;

            for (int row = 0; row < sizeOfMatrix; row++)
            {
                int[] numbers = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();

                for (int col = 0; col < sizeOfMatrix; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            for (int row = 0; row < sizeOfMatrix; row++)
            {
                primarySum += matrix[row, row];
            }

            int secondaryRow = 0;

            for (int col = matrix.GetLength(0) - 1; col >= 0; col--)
            {
                
                secondarySum += matrix[secondaryRow, col];
                secondaryRow++;
            }

            Console.WriteLine(Math.Abs(primarySum - secondarySum));
        }
    }
}
