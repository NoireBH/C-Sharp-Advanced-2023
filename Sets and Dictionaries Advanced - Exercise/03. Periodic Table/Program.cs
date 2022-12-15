using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfChemicals = int.Parse(Console.ReadLine());
            SortedSet<string> uniqueChemicals = new SortedSet<string>();

            for (int i = 0; i < numberOfChemicals; i++)
            {
                string[] chemicalCompounds = Console.ReadLine().Split(' ');

                foreach (var compound in chemicalCompounds)
                {
                    uniqueChemicals.Add(compound);
                }

            }

            Console.WriteLine(String.Join(" ", uniqueChemicals));
        }
    }
}
