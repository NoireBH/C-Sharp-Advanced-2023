using System;
using System.Linq;

namespace _9._Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            char[,] matrix = new char[sizeOfMatrix, sizeOfMatrix];
            string[] moveCommands = Console.ReadLine().Split();
            int minerRow = 0;
            int minerCol = 0;
            int coals = 0;

            FillMatrix(sizeOfMatrix, matrix);
            FindStartOfMiner(sizeOfMatrix, matrix, ref minerRow, ref minerCol, ref coals);

            int commandIndex = 0;


            while (commandIndex < moveCommands.Length &&
               coals > 0 &&
               matrix[minerRow, minerCol] != 'e')
            {
                if (Validate(matrix, minerRow, minerCol, moveCommands, commandIndex))
                {
                    if (moveCommands[commandIndex] == "up")
                    {     
                        if (matrix[minerRow - 1, minerCol] == 'c')
                        {

                            matrix[minerRow - 1, minerCol] = '*';
                            coals--;
                            minerRow--;
                        }

                        else
                        {
                            minerRow--;
                        }

                    }

                    else if (moveCommands[commandIndex] == "down")
                    {
                        if (matrix[minerRow + 1, minerCol] == 'c')
                        {

                            matrix[minerRow + 1, minerCol] = '*';
                            coals--;
                            minerRow++;
                        }

                        else
                        {
                            minerRow++;
                        }
                    }

                    else if (moveCommands[commandIndex] == "left")
                    {
                        if (matrix[minerRow, minerCol - 1] == 'c')
                        {

                            matrix[minerRow, minerCol - 1] = '*';
                            coals--;
                            minerCol--;
                        }

                        else
                        {
                            minerCol--;
                        }
                    }

                    else if (moveCommands[commandIndex] == "right")
                    {
                        if (matrix[minerRow, minerCol + 1] == 'c')
                        {

                            matrix[minerRow, minerCol + 1] = '*';
                            coals--;
                            minerCol++;
                        }

                        else
                        {
                            minerCol++;
                        }
                    }
                }

                commandIndex++;
            }

            if (coals <= 0)
            {
                Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                return;
            }

            else if (coals > 0 && matrix[minerRow,minerCol] != 'e')
            {
                Console.WriteLine($"{coals} coals left. ({minerRow}, {minerCol})");
            }

            else if (matrix[minerRow,minerCol] == 'e')
            {
                Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
            }

        }

        private static bool Validate(char[,] matrix, int minerRow, int minerCol, string[] directions, int indexOfDirection)
        {

            if (directions[indexOfDirection] == "up")
            {
                if (minerRow - 1 < 0)
                {
                    return false;
                }
            }
            else if (directions[indexOfDirection] == "down")
            {
                if (minerRow + 1 >= matrix.GetLength(0))
                {
                    return false;
                }
            }
            else if (directions[indexOfDirection] == "left")
            {
                if (minerCol - 1 < 0)
                {
                    return false;
                }
            }
            else if (directions[indexOfDirection] == "right")
            {
                if (minerCol + 1 >= matrix.GetLength(1))
                {
                    return false;
                }
            }

            return true;

        }

        private static void FindStartOfMiner(int sizeOfMatrix, char[,] matrix, ref int minerRowStart, ref int minerColStart, ref int coals)
        {

            for (int r = 0; r < sizeOfMatrix; r++)
            {
                for (int c = 0; c < sizeOfMatrix; c++)
                {
                    if (matrix[r, c] == 's')
                    {
                        minerRowStart = r;
                        minerColStart = c;
                    }

                    else if (matrix[r, c] == 'c')
                    {
                        coals++;
                    }
                }
            }
        }

        private static void FillMatrix(int sizeOfMatrix, char[,] matrix)
        {
            for (int i = 0; i < sizeOfMatrix; i++)
            {
                char[] squareInput = Console.ReadLine().Split()
                    .Select(char.Parse).ToArray();

                for (int j = 0; j < squareInput.Length; j++)
                {
                    matrix[i, j] = squareInput[j];
                }
            }
        }

    }
}
