using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int nameNumber = int.Parse(Console.ReadLine());
            HashSet<string> uniqueNames = new HashSet<string>();
            for (int i = 0; i < nameNumber; i++)
            {
                string name = Console.ReadLine();
                uniqueNames.Add(name);
            }

            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
