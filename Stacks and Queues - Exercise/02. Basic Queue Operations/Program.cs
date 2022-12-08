using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> stack = new Queue<int>();

            int[] commands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int elementsToAdd = commands[0];
            int elementsToRemove = commands[1];
            int elementsToLookFor = commands[2];

            for (int i = 0; i < elementsToAdd; i++)
            {
                stack.Enqueue(numbers[i]);
            }

            for (int i = 0; i < elementsToRemove; i++)
            {
                stack.Dequeue();
            }

            if (stack.Count > 0)
            {
                if (stack.Contains(elementsToLookFor))
                {
                    Console.WriteLine("true");
                }

                else
                {
                    int smallestNum = stack.Min();
                    Console.WriteLine(smallestNum);
                }
            }

            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
