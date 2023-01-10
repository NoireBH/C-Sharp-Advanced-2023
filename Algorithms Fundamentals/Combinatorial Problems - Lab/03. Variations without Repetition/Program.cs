using System;

namespace _03._Variations_without_Repetition
{
    internal class Program
    {
        private static string[] elements;
        private static string[] variations;
        private static bool[] used;
        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split(' ');
            int numberOfVariations = int.Parse(Console.ReadLine());
            variations = new string[numberOfVariations];
            used = new bool[elements.Length];
            GenerateVariations(0);
        }

        private static void GenerateVariations(int index)
        {

            if (index >= variations.Length)
            {
                Console.WriteLine(string.Join(" ", variations));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    variations[index] = elements[i];
                    GenerateVariations(index + 1);
                    used[i] = false;
                }
            }

            
        }

        
    }
}
