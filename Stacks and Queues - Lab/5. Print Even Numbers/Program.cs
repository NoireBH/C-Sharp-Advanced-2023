using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var evenNumbers = new Queue<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Enqueue(number);
                }
            }

            Console.WriteLine(String.Join(",",evenNumbers));


        }
    }
}
