using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SchoolTeams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] girls = Console.ReadLine().Split(", ");
            string[] boys = Console.ReadLine().Split(", ");

            var girlsCombinations = new string[3];
            var boysCombinations = new string[2];

            var girlsTotalCombinations = new List<string[]>();
            var BoysTotalCombinations = new List<string[]>();


            GetCombinations(0, 0, girls, girlsCombinations, girlsTotalCombinations);
            GetCombinations(0, 0, boys, boysCombinations, BoysTotalCombinations);

            foreach (var girl in girlsTotalCombinations)
            {
                foreach (var boy in BoysTotalCombinations)
                {
                    Console.WriteLine($"{string.Join(", ", girl)}, {string.Join(", ", boy)}");
                }
            }

            
            
        }

        private static void GetCombinations(int index, int start, string[] elements,
            string[] combination, List<string[]> totalCombinations )
        {
            if (index >= combination.Length)
            {
                totalCombinations.Add(combination.ToArray()); //Makes a new copy with ToArray because its a reference type
                return;
            }

            for (int i = start; i < elements.Length; i++)
            {
                combination[index] = elements[i];
                GetCombinations(index + 1, i + 1, elements, combination, totalCombinations);

            }
        }

    }
}
