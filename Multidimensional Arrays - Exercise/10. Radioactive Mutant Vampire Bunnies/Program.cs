using System;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int playerRow = 0;
            int playerCol = 0;

            var matrix = new char[rows, cols];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                string rowData = Console.ReadLine();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = rowData[c];

                    if (matrix[r, c] == 'P')
                    {
                        playerRow = r;
                        playerCol = c;
                        matrix[playerRow, playerCol] = '.';

                    }
                }
            }

            string directions = Console.ReadLine();

            foreach (var direction in directions)
            {
                int oldPlayerRow = playerRow;
                int oldPlayerCol = playerCol;

                switch (direction)
                {
                    case 'U':
                        playerRow--;
                        
                        break;
                    case 'D':
                        playerRow++;
                        break;
                    case 'L':
                        playerCol--;
                        break;
                    case 'R':
                        playerCol++;
                        break;
                }

                matrix = SpreadBunnies(rows, cols, matrix, directions);

                if (playerRow < 0 || playerRow >= rows || playerCol < 0 || playerCol >= cols)
                {
                    PrintResults(oldPlayerRow , oldPlayerCol, "won", matrix, rows, cols);
                    break;
                }

                 if (matrix[playerRow, playerCol] == 'B')
                {
                    PrintResults(playerRow, playerCol, "dead", matrix, rows, cols);
                    break;
                }
            }

            
        }

        private static char[,] SpreadBunnies(int rows,int cols, char[,] matrix,string directions)
        {
            char[,] newMatrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    newMatrix[row,col] = matrix[row,col];
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == 'B')
                    {


                        if (row > 0) // up
                        {
                            newMatrix[row - 1, col] = 'B';
                        }
                        if (row < rows - 1) // down
                        {
                            newMatrix[row + 1, col] = 'B';
                        }
                        if (col > 0) // left
                        {
                            newMatrix[row, col - 1] = 'B';
                        }
                        if (col < cols - 1) // right
                        {
                            newMatrix[row, col + 1] = 'B';
                        }
                    }
                }
            }

            return newMatrix;
        }

        private static void PrintResults(int playerRow, int playerCol, string result, char[,] matrix, int rows, int cols)
        {
            for (int r = 0; r < rows; r++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[r,col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine($"{result}: {playerRow} {playerCol}");
        }
    }
}
