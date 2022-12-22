using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isUpperLetter = letter =>
            char.IsUpper(letter[0]);

            string[] text = Console.ReadLine().Split()
                .Where(word => isUpperLetter(word))
                .ToArray();

            foreach (var word in text)
            {
                Console.WriteLine(word);
            }
        }
    }
}
