using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] col = Console.ReadLine()
                     .Split()
                     .Select(int.Parse)
                     .ToArray();
                matrix[row] = col;
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    matrix[row] = matrix[row].Select(x => x * 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(x => x * 2).ToArray();
                }

                else
                {
                    matrix[row] = matrix[row].Select(x => x / 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(x => x / 2).ToArray();
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmd = input.Split();
                string command = cmd[0];
                int row = int.Parse(cmd[1]);
                int col = int.Parse(cmd[2]);
                int value = int.Parse(cmd[3]);

                if (row >= 0 && row < rows && col >= 0 && col < matrix[row].Length)
                {
                    if (command == "Add")
                    {
                        matrix[row][col] += value;
                    }

                    else if (command == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }

                }
            }

            foreach (int[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
