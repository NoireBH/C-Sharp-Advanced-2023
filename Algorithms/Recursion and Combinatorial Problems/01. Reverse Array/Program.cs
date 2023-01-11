using System;
using System.Linq;

namespace _01._Reverse_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int[] reversed = new int[numbers.Length];
            int reversedIndex = numbers.Length - 1;
            ReverseArray(numbers,0, reversed,reversedIndex);
        }

        private static void ReverseArray(int[] numbers,int index, int[] reversed, int reversedIndex)
        {
            if (reversedIndex < 0)
            {   
                Console.WriteLine(String.Join(" ", reversed));
                return;
            }
            reversed[index] = numbers[reversedIndex];
            ReverseArray(numbers, index + 1, reversed, reversedIndex - 1);

             
        }
    }
}
