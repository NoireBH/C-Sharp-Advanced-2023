using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();
            int lowerBound = numbers[0];
            int upperBound = numbers[1];

            var listOfNums = new List<int>();

            for (int number = lowerBound; number <= upperBound; number++)
            {
                listOfNums.Add(number);
            }

            string typeOfNumbers = Console.ReadLine();

            if (typeOfNumbers == "even")
            {
                Predicate<int> isEven = n => n % 2 == 0;
                Console.WriteLine(string.Join(" ", listOfNums.FindAll(isEven)));
            }

            else if (typeOfNumbers == "odd")
            {
                Predicate<int> isOdd = n => n % 2 != 0;
                Console.WriteLine(string.Join(" ",listOfNums.FindAll(isOdd)));
            }
            
        }
    }
}
