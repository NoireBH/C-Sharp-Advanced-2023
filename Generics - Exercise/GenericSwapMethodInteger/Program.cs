using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            int numberOfBoxes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfBoxes; i++)
            {
                int number = int.Parse(Console.ReadLine());
                box.Items.Add(number);
            }

            int[] indexesToSwap = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int firstIndex = indexesToSwap[0];
            int secondIndex = indexesToSwap[1];

            box.Swap(firstIndex, secondIndex);

            Console.WriteLine(box);
        }


    }
}
