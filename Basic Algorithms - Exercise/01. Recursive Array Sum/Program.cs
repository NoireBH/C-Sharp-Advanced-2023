using System;
using System.Linq;

namespace _01._Recursive_Array_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            Console.WriteLine(GetSum(array, 0)); 
        }

        private static int GetSum(int[] array,int index)
        {
            if (index >= array.Length - 1)
            {
                return array[index];

            }
            return array[index] + GetSum(array,index + 1);
        }
    }
}
