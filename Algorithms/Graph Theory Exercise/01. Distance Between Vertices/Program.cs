using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Distance_Between_Vertices
{
    internal class Program
    {
        private static Dictionary<int, List<int>> graph;
        private static bool[] visited;
        static void Main(string[] args)
        {
            int numberOfVerticles = int.Parse(Console.ReadLine());
            int nOfPairsToSearchShortestPath = int.Parse(Console.ReadLine());
            graph = new Dictionary<int, List<int>>();
            visited = new bool[graph.Count];

            for (int i = 0; i < numberOfVerticles; i++)
            {
                string[] line = Console.ReadLine().Split(":");

               
                int parent = int.Parse(line[0]);

                if (line.Length == 1)
                {
                    graph[parent] = new List<int>();
                }

                else
                {
                    List<int> children = line[1].Split()
                        .Select(int.Parse).ToList();

                    graph[parent] = children;
                }
                                
            }

            for (int i = 0; i < nOfPairsToSearchShortestPath; i++)
            {
                string[] pair = Console.ReadLine().Split("-");
                int start = int.Parse(pair[0]);
                int end = int.Parse(pair[1]);
            }

        }
    }
}
