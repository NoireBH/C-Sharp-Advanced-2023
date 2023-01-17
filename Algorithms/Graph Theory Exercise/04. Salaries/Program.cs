using System;
using System.Collections.Generic;

namespace _04._Salaries
{   
    
    internal class Program
    {
        private static List<int>[] graph;
        private static Dictionary<int, int> visited;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            graph = new List<int>[n];
            visited = new Dictionary<int, int>();
            var totalSalary = 0;

            for (int node = 0; node < n; node++)
            {
                graph[node] = new List<int>();
                string line = Console.ReadLine();

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == 'Y')
                    {
                        graph[node].Add(i);
                    }
                }
                
            }

            for (int node = 0; node < graph.Length; node++)
            {
                var salary = DFS(node);
                totalSalary += salary;
            }

            Console.WriteLine(totalSalary);
        }

        private static int DFS(int node)
        {
            if (visited.ContainsKey(node))
            {
                return visited[node];
            }

            var salary = 0;

            if (graph[node].Count == 0)
            {
                return 1;
            }

            
            foreach (var child in graph[node])
            {
                salary += DFS(child);
            }

            visited[node] = salary;
            return salary;
        }
    }
}
