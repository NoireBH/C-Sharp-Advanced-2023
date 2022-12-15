using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split()
                .Select(double.Parse).ToArray();

            Dictionary<double, int> sameValues = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!sameValues.ContainsKey(numbers[i]))
                {
                    sameValues.Add(numbers[i], 1);
                }

                else
                {
                    sameValues[numbers[i]]++;
                }
            }

            foreach (var number in sameValues)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }

        }
    }
}
