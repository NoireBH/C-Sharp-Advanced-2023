using System;
using System.IO;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(",")
                .Select(int.Parse)
                .OrderBy(n => n)
                .ToArray();

            Console.WriteLine(string.Join(", ", numbers.Where(n => n % 2 == 0)));
        }

     
    }
}
