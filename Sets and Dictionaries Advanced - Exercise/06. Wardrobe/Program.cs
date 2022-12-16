using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int numberOfClothes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfClothes; i++)
            {
                string[] clothes = Console.ReadLine().Split(" -> ");
                string color = clothes[0];
                string[] typesOfClothes = clothes[1].Split(',');

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                foreach (var item in typesOfClothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 1);
                    }

                    else
                    {
                        wardrobe[color][item]++;
                    }
                }
            }

            string[] searchedItem = Console.ReadLine().Split();
            string searchedColor = searchedItem[0];
            string searchedTypeOfDress = searchedItem[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var clothType in color.Value)
                {
                    if (color.Key == searchedColor && clothType.Key == searchedTypeOfDress)
                    {
                        Console.WriteLine($"* {clothType.Key} - {clothType.Value} (found!)");
                    }

                    else
                    {
                        Console.WriteLine($"* {clothType.Key} - {clothType.Value}");
                    }
                    
                }
            }


        }
    }
}
