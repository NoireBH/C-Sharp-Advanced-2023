using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

            int divisibleNumber = int.Parse(Console.ReadLine());

            Func<List<int>, List<int>> divideByNumber = list => list.Where(x => x % divisibleNumber != 0).Reverse().ToList();

            Console.WriteLine(string.Join(" ", divideByNumber(numbers)));

        }
    }
}
