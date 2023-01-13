using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfCoins

{


    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] coins = Console.ReadLine().Split(", ")
                .Select(int.Parse).ToArray();
            int desiredSum = int.Parse(Console.ReadLine());

            var selectedCoins = ChooseCoins(coins, desiredSum);

            Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");

            foreach (var item in selectedCoins)
            {
                Console.WriteLine($"{item.Value} coin(s) with value {item.Key}");
            }

        }

        public static Dictionary<int, int> ChooseCoins(int[] coins, int targetSum)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            int sum = 0;
            int indexOfCoins = 0;
            int[] sortedCoins = coins.OrderByDescending(c => c).ToArray();

            while (sum != targetSum && indexOfCoins < sortedCoins.Length)
            {
                int currentCoin = sortedCoins[indexOfCoins];
                int remainder = targetSum - sum;
                int numberOfCoins = remainder / currentCoin;

                if (sum + currentCoin <= targetSum)
                {
                    result.Add(currentCoin, numberOfCoins);
                    sum += currentCoin * numberOfCoins;
                }
                indexOfCoins++;
            }

            if (sum != targetSum)
            {
                throw new InvalidOperationException();
            }



            return result;
        }
    }
}