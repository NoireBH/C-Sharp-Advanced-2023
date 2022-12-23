using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> VAT = n => n * 1.20;

            double[] numbers = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(VAT)
                .ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:f2}");
            }
        }
    }
}
