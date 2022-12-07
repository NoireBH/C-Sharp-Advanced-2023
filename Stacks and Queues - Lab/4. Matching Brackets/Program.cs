using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            var indexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    indexes.Push(i);
                }

                else if (expression[i] == ')')
                {
                    int openBracketIndex = indexes.Pop();
                    int closeBracketIndex = i;
                    Console.WriteLine(expression.Substring(openBracketIndex,closeBracketIndex - openBracketIndex + 1));
                }
            }
        }
    }
}
