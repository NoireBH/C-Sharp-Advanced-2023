using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Permutations_with_Repetition
{
    internal class Program
    {
        public static bool[] used;
        public static string[] elements;
        public static string[] permutations;
        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split(' ');
            permutations = new string[elements.Length];
            Permute(0);
        }

        private static void Permute(int index)
        {

            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", permutations));
                return;
            }

            Permute(index + 1);
            var swapped = new HashSet<string> { permutations[index] };
            for (int i = index + 1; i < permutations.Length; i++)
            {
                if (!swapped.Contains(permutations[i]))
                {
                    Swap(index, i);
                    Permute(index + 1);
                    Swap(index, i);
                    swapped.Add(permutations[i]);

                }
            }
        }

        private static void Swap(int index, int i)
        {
            int temp = index;
            index = i;
            i = temp;
        }
    }
}

