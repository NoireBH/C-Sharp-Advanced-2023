using System;
using System.Linq;

namespace _06._Merge_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int[] sortedNumbers = MergeSort(numbers);
            Console.WriteLine(String.Join(" ", sortedNumbers));
        }

        private static int[] MergeSort(int[] numbers)
        {
            if (numbers.Length <= 1)
            {
                return numbers;
            }

            var left = numbers.Take(numbers.Length / 2).ToArray();
            var right = numbers.Skip(numbers.Length / 2).ToArray();
            return Merge(MergeSort(left), MergeSort(right));
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int[] mergedArray = new int[left.Length + right.Length];
            int mergedIndex = 0;
            int leftIndex = 0;
            int rightIndex = 0; 

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    mergedArray[mergedIndex++] = left[leftIndex++];
                }

                else
                {
                    mergedArray[mergedIndex++] = right[rightIndex++];
                }
            }

            for (int i = leftIndex; i < left.Length; i++)
            {
                mergedArray[mergedIndex++] = left[i];
            }

            for (int i = rightIndex; i < right.Length; i++)
            {
                mergedArray[mergedIndex++] = right[i];
            }

            return mergedArray;
        }
    }
}
