using System;
using System.Collections.Generic;
using System.Linq;

namespace TopSort
{
    internal class Program
    {
        private static Dictionary<string, List<string>> graph;
        private static Dictionary<string, int> dependecies;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            graph = ReadGraph(n);
            dependecies = ExtractDependencies(graph);
            var sorted = new List<string>();

            while (dependecies.Count > 0)
            {
                var nodeToRemove = dependecies.FirstOrDefault(d => d.Value == 0).Key;
                

                if (nodeToRemove == null)
                {
                    break;
                }

                    dependecies.Remove(nodeToRemove);
                    sorted.Add(nodeToRemove);

                foreach (var child in graph[nodeToRemove])
                {
                    dependecies[child]--;
                }
                
            }

            if (dependecies.Count == 0)
            {
                Console.WriteLine($"Topological sorting: {String.Join(", ", sorted)}");
            }

            else
            {
                Console.WriteLine("Invalid topological sorting");
            }
           
        }

        private static Dictionary<string, int> ExtractDependencies(Dictionary<string, List<string>> graph)
        {
            var result = new Dictionary<string, int>();

            foreach (var kvp in graph)
            {
                var node = kvp.Key;
                var children = kvp.Value;

                if (!result.ContainsKey(node))
                {
                    result[node] = 0;
                }

                foreach (var child in children)
                {
                    if (!result.ContainsKey(child))
                    {
                        result[child] = 1;
                    }

                    else
                    {
                        result[child]++;
                    }
                }
  
            }

            return result;
        }

        private static Dictionary<string, List<string>> ReadGraph(int n)
        {
            var result = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                var parts = Console.ReadLine().Split("->",StringSplitOptions.RemoveEmptyEntries)
                    .Select(e => e.Trim())
                    .ToArray();

                var key = parts[0];

                if (parts.Length == 1)
                {
                    result[key] = new List<string>();
                }

                else
                {
                    var children = parts[1].Split(", ").ToList();
                    result[key] = children;
                }
                
            }

            return result;
        }
    }
}
