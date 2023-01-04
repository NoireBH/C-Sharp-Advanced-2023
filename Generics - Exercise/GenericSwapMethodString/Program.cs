using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int numberOfBoxes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfBoxes; i++)
            {
                string text = Console.ReadLine();
                box.Items.Add(text);
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
