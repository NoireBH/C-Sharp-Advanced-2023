using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isUpperLetter = letter =>
            char.IsUpper(letter[0]);

            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(word => isUpperLetter(word))
                .ToArray();

            foreach (var word in text)
            {
                Console.WriteLine(word);
            }
        }
    }
}
