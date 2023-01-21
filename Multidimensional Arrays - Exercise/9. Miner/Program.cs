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
               matrix[minerRow,minerCol] != 'e')
            {
                if (moveCommands[commandIndex] == "up")
                {
                    commandIndex++;

                    if (matrix[minerRow - 1, minerCol] < 0 || matrix[minerRow - 1, minerCol] >= matrix.GetLength(1))
                    {   
                        continue;
                    }

                    if (matrix[minerRow - 1, minerCol] == 'c')
                    {   

                        matrix[minerRow - 1, minerCol] = '*';
                        coals--;
                        minerCol++;
                        minerRow--;

                        
                    }
                }
            }

            if (coals <= 0)
            {
                Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                return;
            }

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

                    else if (matrix[r,c] == 'c')
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
