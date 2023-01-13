using System;
using System.Linq;

namespace _03._Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            BubleSort(numbers);
            Console.WriteLine(String.Join(" ",numbers));

        }

        private static void BubleSort(int[] numbers)
        {
            var sortedCount = 0;
            bool isSorted = false;

            while (!isSorted)
            {   
                isSorted = true;

                for (int j = 1; j < numbers.Length - sortedCount; j++)
                {
                    int i = j - 1;

                    if (numbers[i] > numbers[j])
                    {
                        Swap(numbers, i, j);
                        isSorted = false;
                    }
                }

                sortedCount++;
            }
        }

        private static void Swap(int[] numbers, int first, int second)
        {
            var temp = numbers[first];
            numbers[first] = numbers[second];
            numbers[second] = temp;
        }
    }
}
