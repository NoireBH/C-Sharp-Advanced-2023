using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> stones = Console.ReadLine()
                .Split(", ").Select(int.Parse).ToList();

            Lake lake = new Lake(stones);

            Console.WriteLine(String.Join(", ", lake));
        }
    }
}
