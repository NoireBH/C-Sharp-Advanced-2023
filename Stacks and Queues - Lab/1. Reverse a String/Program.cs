using System;
using System.Collections;

namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack reversedString = new Stack();

            foreach (var letter in input)
            {
                reversedString.Push(letter);
            }

            while (reversedString.Count > 0)
            {
                Console.Write(reversedString.Pop());
            }
            
            
        }
    }
}
