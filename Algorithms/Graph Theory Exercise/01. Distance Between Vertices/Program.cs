using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Distance_Between_Vertices
{
    internal class Program
    {
        private static Dictionary<int, List<int>> graph;
        static void Main(string[] args)
        {
            int numberOfVerticles = int.Parse(Console.ReadLine());
            int nOfPairsToSearchShortestPath = int.Parse(Console.ReadLine());
            graph = new Dictionary<int, List<int>>();
            

            for (int i = 0; i < numberOfVerticles; i++)
            {
                string[] line = Console.ReadLine().Split(":",StringSplitOptions.RemoveEmptyEntries);

               
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

                var steps = BFS(start, end);

                Console.WriteLine($"{{{ String.Join(", ", pair)}}} -> {steps}");
                

            }

        }

        private static int BFS(int start, int end)
        {
            var visited = new HashSet<int> { start };
            Queue<int> queue = new Queue<int>();
            var parent = new Dictionary<int, int> { { start, -1 } };

            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node == end)
                {
                    var steps = GetPath(end,parent);

                    return steps;
                }
                foreach (var child in graph[node])
                {
                    if (visited.Contains(child))
                    {
                        continue;
                    }

                    parent[child] = node;
                    visited.Add(child);
                    queue.Enqueue(child);
                }
            }

            return -1;
        }

        private static int GetPath(int end,Dictionary<int,int> parent)
        {
            int steps = 0;
            var node = end;

            while (node != -1)
            {
                steps++;
                node = parent[node];
            }

            return steps - 1;
        }
    }
}
