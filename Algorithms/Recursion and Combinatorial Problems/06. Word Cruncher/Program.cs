using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Word_Cruncher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToCombine = Console.ReadLine().Split(", ");
            string neededWord = Console.ReadLine();
            Combinations(0,0, wordsToCombine,neededWord);

        }

        static void Combinations(int index, int start, string[] elements, string neededWord)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", elements));
                return;
            }
                
                for (int i = start; i < elements.Length; i++)
                {
                    elements[index] = elements[i];
                    Combinations(index + 1, i, elements, neededWord);
                }
            
        }


        private static void Swap(int first, int second, string[] elements)
        {
            var temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }

    }
}
