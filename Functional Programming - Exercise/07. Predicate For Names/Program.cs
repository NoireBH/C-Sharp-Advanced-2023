using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int neededLength = int.Parse(Console.ReadLine());
            Predicate<string> isLessOrEqual = word => word.Length <= neededLength;

            List<string> names = Console.ReadLine().Split()
                .ToList();

            foreach (var name in names)
            {
                if (isLessOrEqual(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
