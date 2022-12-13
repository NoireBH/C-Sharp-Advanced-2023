using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowAndCols = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rowAndCols, rowAndCols];

            for (int i = 0; i < rowAndCols; i++)
            {
                char[] characters = Console.ReadLine()
                    .ToCharArray();
                    

                for (int j = 0; j < rowAndCols; j++)
                {
                    matrix[i, j] = characters[j];
                }
            }

            char characterNeeded = char.Parse(Console.ReadLine());
            bool foundMatch = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (foundMatch)
                {
                    break;
                }

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == characterNeeded)
                    {
                        Console.WriteLine($"({row}, {col})");
                        foundMatch = true;
                        break;
                    }
                }
            }

            if (!foundMatch)
            {
                Console.WriteLine($"{characterNeeded} does not occur in the matrix ");
            }


        }
    }
}
