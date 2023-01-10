using System;

namespace _04._Variations_with_Repetition
{
    internal class Program
    {
        private static string[] elements;
        private static string[] variations;
        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split(' ');
            int numberOfVariations = int.Parse(Console.ReadLine());
            variations = new string[numberOfVariations];
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
                    variations[index] = elements[i];
                    GenerateVariations(index + 1);
                
            }


        }


    }
}
