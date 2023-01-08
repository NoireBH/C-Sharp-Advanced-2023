using System;

namespace _01._Permutations_without_Repetition
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
            used = new bool[elements.Length];
            
            Permute(0);
        }

        private static void Permute(int index)
        {   
            
            if (index >= permutations.Length)
            {
                Console.WriteLine(string.Join(" ", permutations));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (!used[i])
                {   
                    used[i] = true;
                    permutations[index] = elements[i];
                    Permute(index + 1);
                    used[i] = false;
                }
            }
        }
    }
}
