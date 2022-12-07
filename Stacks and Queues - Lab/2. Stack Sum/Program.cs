using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int>stackedNums = new Stack<int>();

            foreach (var num in numbers)
            {
                stackedNums.Push(num);
            }        

            while (true)
            {
                string input = Console.ReadLine();
                string[] cmd = input.Split();
                string command = cmd[0].ToLower();

                if (command == "end")
                {
                    break;
                }
                else if (command == "add")
                {
                    int n1 = int.Parse(cmd[1]);
                    int n2 = int.Parse(cmd[2]);
                    stackedNums.Push(n1);
                    stackedNums.Push(n2);
                }

                else if (command == "remove")
                {
                    int elementsToRemove = int.Parse(cmd[1]);

                    if (elementsToRemove <= stackedNums.Count)
                    {
                        for (int i = 0; i < elementsToRemove; i++)
                        {
                            stackedNums.Pop();
                        }
                    }
                    
                }
            }

            Console.WriteLine("Sum: " + stackedNums.Sum());
        }
    }
}
