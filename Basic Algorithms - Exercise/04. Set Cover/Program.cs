using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Set_Cover
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> universe = Console.ReadLine().Split(", ")
                .Select(int.Parse).ToList();

            int numberOfSets = int.Parse(Console.ReadLine());
            var sets = new List<int[]>();

            for (int i = 0; i < numberOfSets; i++)
            {
                int[] set = Console.ReadLine().Split(", ")
                .Select(int.Parse).ToArray();
                sets.Add(set);
            }

            var selectedSets = new List<int[]>();

            while (universe.Count > 0)
            {
                var longestSet = sets.OrderByDescending(s => s.Count(x => universe.Contains(x)))
                    .FirstOrDefault();
                selectedSets.Add(longestSet);
                sets.Remove(longestSet);

                foreach (var item in longestSet)
                {
                    universe.Remove(item);
                }
            }

            Console.WriteLine($"Sets to take ({selectedSets.Count}):");

            foreach (var set in selectedSets)
            {
                Console.WriteLine($"{string.Join(", ", set)}");
            }

        }
    }
}
