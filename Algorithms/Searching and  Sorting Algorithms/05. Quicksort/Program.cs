using System;
using System.Linq;

namespace _05._Quicksort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            QuickSort(numbers, 0 , numbers.Length - 1);
            Console.WriteLine(String.Join(" ", numbers));
        }

        private static void QuickSort(int[] numbers,int startIdx, int endIdx)
        {
            int pivot = startIdx;
            int leftIdx = startIdx + 1;
            int rightIdx = endIdx;

            if (startIdx >= endIdx)
            {
                return;
            }

            while (leftIdx <= rightIdx)
            {
                if (numbers[leftIdx] > numbers[pivot] &&
                    numbers[rightIdx] < numbers[pivot])
                {
                    Swap(numbers, leftIdx, rightIdx);
                }

                if (numbers[leftIdx] <= numbers[pivot])
                {
                    leftIdx++;
                }

                if (numbers[rightIdx] >= numbers[pivot])
                {
                    rightIdx--;
                }
            }

            Swap(numbers, pivot, rightIdx);
            QuickSort(numbers, startIdx, rightIdx - 1);
            QuickSort(numbers, rightIdx + 1, endIdx);
        }

        private static void Swap(int[] numbers, int first, int second)
        {
            var temp = numbers[first];
            numbers[first] = numbers[second];
            numbers[second] = temp;
        }
    }
}
