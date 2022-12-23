using System;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            Action<string> print = message => Console.WriteLine(message);

            foreach (var @string in strings)
            {
                print(@string);
            }
        }
    }
}
