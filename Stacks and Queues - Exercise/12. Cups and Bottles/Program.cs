using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cupCapacity = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] filledBottles = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var cups = new Queue<int>(cupCapacity);
            var bottles = new Stack<int>(filledBottles);
            int waterWasted = 0;
            

            while (cups.Count > 0 && bottles.Count > 0)
            {
                    int currentBottle = bottles.Pop();
                int currentCup = cups.Dequeue();

                if (currentBottle - currentCup >= 0)
                {
                    waterWasted += currentBottle - currentCup;
                    continue;
                }

                currentCup -= currentBottle;

                while (bottles.Count > 0)
                {
                    int bottle = bottles.Pop();

                    if (bottle - currentCup >= 0)
                    {
                        waterWasted += bottle - currentCup;
                        break;
                    }

                    currentCup -= bottle;

                }
            }

            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }

            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {waterWasted}");
        }
    }
}
