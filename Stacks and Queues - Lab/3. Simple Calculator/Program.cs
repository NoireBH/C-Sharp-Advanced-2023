using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numAndOps = Console.ReadLine()
                .Split();
            
            Stack<string> stack = new Stack<string>(numAndOps.Reverse());
            int sum = 0;
            while (stack.Count > 1)
            {
                int n1 = int.Parse(stack.Pop());
                string operation = stack.Pop();
                int n2 = int.Parse(stack.Pop());

                switch (operation)
                {
                    case "+": 
                        stack.Push((n1 + n2).ToString()); 
                        break;

                    case "-": 
                        stack.Push((n1 - n2).ToString()); 
                        break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
