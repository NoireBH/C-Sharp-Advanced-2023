using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int[] clothesInBox = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            var boutiqueStack = new Stack<int>(clothesInBox);
            int rackCapacity = int.Parse(Console.ReadLine());
            int sumOfClothes = 0;
            int numberOfRacks = 1;
            while (boutiqueStack.Count > 0)
            {

                int currentBoutique = boutiqueStack.Pop();
                if (sumOfClothes + currentBoutique <= rackCapacity)
                {
                    sumOfClothes += currentBoutique;
                }

                else
                {
                    sumOfClothes = currentBoutique;
                    numberOfRacks++;
                }
            }

            Console.WriteLine(numberOfRacks);

        }
    }
}
