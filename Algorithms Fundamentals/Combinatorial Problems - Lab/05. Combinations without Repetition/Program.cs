using System;

namespace _05._Combinations_without_Repetition
{
    internal class Program
    {
        private static string[] elements;
        private static string[] combinations;
        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split(' ');
            int numberOfVariations = int.Parse(Console.ReadLine());
            combinations = new string[numberOfVariations];
            GenerateCombinations(0,0);
        }

        private static void GenerateCombinations(int index,int elementsStartingIndex)
        {

            if (index >= combinations.Length)
            {
                Console.WriteLine(string.Join(" ", combinations));
                return;
            }

            for (int i = elementsStartingIndex; i < elements.Length; i++)
            {
                    combinations[index] = elements[i];
                    GenerateCombinations(index + 1, i);
                
            }


        }


    }
}
