using System;

namespace _03._Generating_01_Vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfVectors = int.Parse(Console.ReadLine());
            int[] array = new int[numberOfVectors];
            PrintVectors(array,0);

        }

        public static void PrintVectors(int[] vector, int index)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(String.Join(String.Empty, vector));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                vector[index] = i;
                PrintVectors(vector, index + 1);

            }

            
        }
    }
    }

    

