using System;
using System.Linq;

namespace _01._Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            

            int numberToSearchFor = int.Parse(Console.ReadLine());
            Console.WriteLine(BinarySearch(numbers, numberToSearchFor)); 


        }

        private static int BinarySearch(int[] numbers,int searched)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (numbers[mid] == searched)
                {
                    return mid;
                }

                if (searched > numbers[mid])
                {
                    left = mid + 1;
                }

                else
                {
                    right = mid - 1;
                }
        
            }

            return -1;
        }
    }
}
