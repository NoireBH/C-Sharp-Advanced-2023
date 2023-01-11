using System;

namespace _02._Nested_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            GenerateLoop(numbers,0);

        }

        private static void GenerateLoop(int[] numbers, int index)
        {
            if (index >= numbers.Length)
            {
                Console.WriteLine(String.Join(" ", numbers));
                return;
            }

            for (int i = 1; i <= numbers.Length; i++)
            {
                numbers[index] = i;
                GenerateLoop(numbers,index + 1);
            }
        }
    }
}
