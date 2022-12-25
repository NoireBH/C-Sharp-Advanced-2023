using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> peopleInvitedToParty = Console.ReadLine().Split()
                .ToList();

            Console.WriteLine(peopleInvitedToParty.First(name => name.Select(symbol => (int) symbol).Sum() >= number));
        }
    }
}
