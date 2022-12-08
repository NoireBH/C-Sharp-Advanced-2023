using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Stack<int> stack = new Stack<int>();
            int[] commands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int elementsToPush = commands[0];
            int elementsToPop = commands[1];
            int elementsToLookFor = commands[2];

            for (int i = 0; i < elementsToPush; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
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
