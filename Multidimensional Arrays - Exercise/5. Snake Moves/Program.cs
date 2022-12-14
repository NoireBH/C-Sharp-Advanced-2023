using System;
using System.Linq;

namespace _5._Snake_Moves
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
            string snake = Console.ReadLine();
            int indexOfSnake = 0;

            for (int row = 0; row < numberOfRows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < numberOfCols; col++)
                    {
                        matrix[row, col] = snake[indexOfSnake];
                        indexOfSnake++;

                        if (indexOfSnake >= snake.Length)
                        {
                            indexOfSnake = 0;
                        }
                    }
                }

                else
                {
                    for (int col = numberOfCols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[indexOfSnake];
                        indexOfSnake++;

                        if (indexOfSnake >= snake.Length)
                        {
                            indexOfSnake = 0;
                        }
                    }
                }
                
            }
            PrintMatrix(matrix);
        }
        public static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

    }
}
