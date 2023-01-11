using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectedAreasInAMatr
{
    internal class Program
    {
        private static char[,] matrix;
        private static int size = 0;
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            matrix = new char[rows, cols];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {   
                string colElemets = Console.ReadLine();

                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = colElemets[c];
                }
            }

            var areas = new List<Area>();

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    size = 0;
                    ExploreArea(r, c);

                    if (size != 0)
                    {
                        areas.Add(new Area { Row = r, Col = c, Size = size });
                    }
                }
            }

            var sortedAreas = areas.OrderByDescending(a => a.Size)
                .ThenBy(a => a.Row)
                .ThenBy(a => a.Col)
                .ToList();

            Console.WriteLine($"Total areas found: {areas.Count}");

            for (int i = 0; i < sortedAreas.Count; i++)
            {
                var area = sortedAreas[i];

                Console.WriteLine($"Area #{i + 1} at ({area.Row}, {area.Col}), size: {area.Size}");
            }
        }

        private static void ExploreArea(int row, int col)
        {
            if (IsOutside(row,col) || IsWall(row,col) || IsVisited(row,col))
            {
                return;
            }

            size++;
            matrix[row, col] = 'V';

            ExploreArea(row - 1, col); //UP
            ExploreArea(row + 1, col); //DOWN
            ExploreArea(row, col - 1); // LEFT
            ExploreArea(row, col + 1); // RIGHT
        }

        private static bool IsVisited(int row, int col)
        {
            return matrix[row, col] == 'V';
        }

        private static bool IsWall(int row, int col)
        {
            return matrix[row, col] == '*';
        }

        private static bool IsOutside(int row, int col)
        {
            
            return row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1);
        }

        public class Area
        {
            public int Row { get; set; }
            public int Col { get; set; }
            public int Size { get; set; }


        }
    }
}
