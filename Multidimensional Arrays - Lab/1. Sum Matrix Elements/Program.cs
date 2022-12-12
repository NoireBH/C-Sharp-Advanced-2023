using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberOfRowsANdColumns = Console.ReadLine().Split(", ")
                .Select(int.Parse)
                .ToArray();
            int rows = numberOfRowsANdColumns[0];
            int columns = numberOfRowsANdColumns[1];
            int[,] matrix = new int[rows, columns];
            

            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ")
                                      .Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[row, col] = colElements[col];

            }

                Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));

            foreach (var item in matrix)
            {
                sum += item;
            }
            
            Console.WriteLine(sum);
        }
    }
}
