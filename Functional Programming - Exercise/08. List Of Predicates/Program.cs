using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());
            
            List<int> dividers = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

            List<int> numbers = new List<int>();

            for (int i = 1; i <= endOfRange; i++)
            {
                numbers.Add(i);
            }

            List<int> divisibleNumbers = new List<int>();

            foreach (var number in numbers)
            {
                bool isAbleToBeDivided = true;

                foreach (var divider in dividers)
                {
                    Predicate<int> isDivisible = number => number % divider == 0;

                    if (!isDivisible(number))
                    {
                        isAbleToBeDivided = false;
                        break;                  
                    }
                }

                if (isAbleToBeDivided)
                {
                    divisibleNumbers.Add(number);
                }
            }

            Console.WriteLine(String.Join(" ", divisibleNumbers));
        }
    }
}
