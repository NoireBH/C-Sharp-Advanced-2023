using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
            int sum = 0;
            for (int i = 0; i < sizeOfMatrix; i++)
            {
                int[] numbersPerRow = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();

                for (int j = 0; j < sizeOfMatrix; j++)
                {
                    matrix[i, j] = numbersPerRow[j];
                }
            }

            for (int row = 0; row < sizeOfMatrix; row++)
            {
                sum += matrix[row, row];

            }
            Console.WriteLine(sum); 
        }
    }
}
