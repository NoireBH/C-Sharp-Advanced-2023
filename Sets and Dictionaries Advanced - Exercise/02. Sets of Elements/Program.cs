using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            HashSet<int> firstElement = new HashSet<int>();
            HashSet<int> secondElement = new HashSet<int>();


            for (int i = 0; i < numbers[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstElement.Add(number);
            }

            for (int i = 0; i < numbers[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondElement.Add(number);
            }

            firstElement.IntersectWith(secondElement);
            Console.WriteLine(String.Join(" ", firstElement));
        }
    }
}
