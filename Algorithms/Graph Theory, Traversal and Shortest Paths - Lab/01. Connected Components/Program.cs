using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Connected_Components
{
    internal class Program
    {
        private static List<int>[] graph;
        private static bool[] visited;
        static void Main(string[] args)
        {           
            int n = int.Parse(Console.ReadLine());
            graph = new List<int>[n];
            visited = new bool[graph.Length];

            for (int node = 0; node < n; node++)
            {
                string line = Console.ReadLine();

                if (string.IsNullOrEmpty(line))
                {
                    
                    graph[node] = new List<int>();
                }

                else
                {
                    var chilren = line.Split().Select(int.Parse)
                        .ToList();
                    graph[node] = chilren;
                }
            }

            for (int node = 0; node < graph.Length; node++)
            {
                if (visited[node])
                {
                    continue;
                }

                var component = new List<int>();
                DFS(node,component);

                Console.WriteLine($"Connected component: { String.Join(" ", component)}");
            }
        }

        private static void DFS(int node,List<int> component)
        {
            if (visited[node])
            {
                return;
            }

            visited[node] = true;

            foreach (var child in graph[node])
            {
                DFS(child,component);
            }

            component.Add(node);
        }
    }
}
