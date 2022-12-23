using System;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            Action<string> print = message => Console.WriteLine("Sir " + message);

            foreach (var @string in strings)
            {
                print(@string);
            }
        }
    }
}
