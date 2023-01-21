using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var symbolCount = new SortedDictionary<char, int>();
            string text = Console.ReadLine();

            foreach (char character in text)
            {
                if (!symbolCount.ContainsKey(character))
                {
                    symbolCount[character] = 0;
                }
                   
                symbolCount[character]++;
                
            }

            foreach (var (symbol,count) in symbolCount)
            {
                Console.WriteLine($"{symbol}: {count} time/s");
            }

        }
    }
}
