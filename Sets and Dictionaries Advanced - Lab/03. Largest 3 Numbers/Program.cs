using System;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split()
               .Select(int.Parse).ToArray();
            numbers = numbers.OrderByDescending(x => x).ToArray();

            if (numbers.Length >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }

            else
            {
                foreach (var number in numbers)
                {
                    Console.Write($"{number} ");
                }
            }
            
        }
    }
}
