using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = n => int.Parse(n);
            int[] numbers = Console.ReadLine()
                 .Split(", ")
                 .Select(parser)
                 .ToArray();
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());
        }
    }
}
