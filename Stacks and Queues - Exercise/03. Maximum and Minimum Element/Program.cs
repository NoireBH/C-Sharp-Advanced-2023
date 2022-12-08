using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();

            int n =int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] commands = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                

                if (commands[0] == 1)
                {
                    stack.Push(commands[1]);
                }

                if (stack.Count == 0)
                {
                    continue;
                }

                else if (commands[0] == 2)
                {                 
                    stack.Pop();
                }

                else if (commands[0] == 3)
                {
                        int maxNum = stack.Max();
                        Console.WriteLine(maxNum);                  
                }

                else if (commands[0] == 4)
                {                                     
                        int minNum = stack.Min();
                        Console.WriteLine(minNum);
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
