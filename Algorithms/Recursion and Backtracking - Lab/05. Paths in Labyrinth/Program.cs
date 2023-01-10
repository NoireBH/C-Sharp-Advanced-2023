using System;
using System.Collections.Generic;

namespace _05._Paths_in_Labyrinth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            List<string> path = new List<string>();

            char[,] labyrinth = new char[rows, columns];


            for (int r = 0; r < rows; r++)
            {
                var lab = Console.ReadLine();

                for (int c = 0; c < columns; c++)
                {
                    labyrinth[r, c] = lab[c];
                }
            }

            FindPath(labyrinth, 0, 0, path, string.Empty);
        }

        private static void FindPath(char[,] lab, int row, int col, List<string> path, string direction)
        {


            if (row < 0 || row >= lab.GetLength(0) || col < 0 || col >= lab.GetLength(1))
            {
                return;
            }

            if (lab[row,col] == '*' || lab[row,col] == 'V')
            {
                return;
            }
            path.Add(direction);

            if (lab[row, col] == 'e')
            {
                Console.WriteLine(string.Join(String.Empty, path));
                path.RemoveAt(path.Count - 1);
                return;
            }

            lab[row, col] = 'V';

            FindPath(lab, row - 1, col, path, "U"); // UP
            FindPath(lab, row + 1, col, path, "D"); // Down
            FindPath(lab, row, col - 1, path, "L"); // Left
            FindPath(lab, row, col + 1, path, "R"); // Right

            lab[row, col] = '-';
            path.RemoveAt(path.Count - 1);
        }
    }
}
