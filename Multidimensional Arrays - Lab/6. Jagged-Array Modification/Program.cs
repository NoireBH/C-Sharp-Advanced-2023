using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] col = Console.ReadLine()
                     .Split()
                     .Select(int.Parse)
                     .ToArray();
                matrix[i] = col;
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] cmd = input.Split();
                string command = cmd[0];
                int row = int.Parse(cmd[1]);
                int col = int.Parse(cmd[2]);
                int value = int.Parse(cmd[3]);

                if (row < 0 || row >= matrix.Length || col < 0 || col >= matrix.Length)
                {
                     Console.WriteLine("Invalid coordinates");
                }

                else
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
