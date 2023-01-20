using System;
using System.Linq;

namespace _8._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
            FillMatrix(sizeOfMatrix, matrix);

            string[] bombs = Console.ReadLine().Split(" ");
            DetonateBombs(matrix, bombs);

            int sumOfAliveCells = 0;
            int aliveCells = 0;
            CalculateSumAndAliveCells(sizeOfMatrix, matrix, ref sumOfAliveCells, ref aliveCells);

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sumOfAliveCells}");

            PrintMatrix(matrix);
        }

        private static void CalculateSumAndAliveCells(int sizeOfMatrix, int[,] matrix, ref int sumOfAliveCells, ref int aliveCells)
        {
            for (int r = 0; r < sizeOfMatrix; r++)
            {
                for (int c = 0; c < sizeOfMatrix; c++)
                {
                    if (matrix[r, c] > 0)
                    {
                        sumOfAliveCells += matrix[r, c];
                        aliveCells++;
                    }
                }
            }
        }

        private static void FillMatrix(int sizeOfMatrix, int[,] matrix)
        {
            for (int i = 0; i < sizeOfMatrix; i++)
            {
                int[] numbers = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();

                for (int j = 0; j < numbers.Length; j++)
                {
                    matrix[i, j] = numbers[j];
                }
            }
        }

        private static void DetonateBombs(int[,] matrix, string[] bombs)
        {
            foreach (string rowColPair in bombs)
            {
                int[] currentBombCoordinates = rowColPair
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentBombRow = currentBombCoordinates[0];
                int currentBombCol = currentBombCoordinates[1];
                int currentBomb = matrix[currentBombRow, currentBombCol];


                for (int row = currentBombRow - 1; row <= currentBombRow + 1; row++)
                {
                    for (int col = currentBombCol - 1; col <= currentBombCol + 1; col++)
                    {
                        if (row >= 0 && row < matrix.GetLength(0)
                            && col >= 0 && col < matrix.GetLength(1))
                        {
                            if (matrix[row, col] <= 0 || currentBomb < 0)
                            {
                                continue;
                            }

                            matrix[row, col] -= currentBomb;
                        }

                    }
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");

                }

                Console.WriteLine();
            }
        }
    }
}
