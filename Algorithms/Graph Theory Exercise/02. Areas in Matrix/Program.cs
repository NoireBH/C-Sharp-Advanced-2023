using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Areas_in_Matrix
{
    internal class Program
    {
        private static char[,] graph;
        private static bool[,] visited;
        private static Dictionary<char,int> areas;
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            graph = new char[rows, cols];
            visited = new bool[rows, cols];
            areas = new Dictionary<char,int>();

            for (int r = 0; r < graph.GetLength(0); r++)
            {   
                var elements = Console.ReadLine();

                for (int c = 0; c < graph.GetLength(1); c++)
                {
                    graph[r, c] = elements[c];
                }
            }

            for (int r = 0; r < graph.GetLength(0); r++)
            {
                for (int c = 0; c < graph.GetLength(1); c++)
                {
                    if (visited[r,c])
                    {
                        continue;
                    }

                    var currentNode = graph[r, c];
                    DFS(r, c,currentNode);

                    if (!areas.ContainsKey(currentNode))
                    {
                        areas[currentNode] = 1;
                    }

                    else
                    {
                        areas[currentNode]++;
                    }
                }
            }
            Console.WriteLine($"Areas: {areas.Values.Sum()}");

            foreach (var area in areas.OrderBy(x => x.Key))
            {
                
                Console.WriteLine($"Letter '{area.Key}' -> {area.Value}");
            }

        }

        private static void DFS(int row, int col, char currentNode)
        {
            if (row <0 || row >= graph.GetLength(0) || col < 0 || col >= graph.GetLength(1))
            {
                return;
            }

            if (visited[row,col])
            {
                return;
            }

            if (graph[row,col] != currentNode)
            {
                return;
            }

            visited[row,col] = true;

            DFS(row, col - 1, currentNode);
            DFS(row, col + 1, currentNode);
            DFS(row + 1, col , currentNode);
            DFS(row - 1, col , currentNode);
        }
    }
}
