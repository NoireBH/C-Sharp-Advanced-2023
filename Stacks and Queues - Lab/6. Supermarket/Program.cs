using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    foreach (var person in queue)
                    {
                        Console.WriteLine(person);
                    }
                    queue.Clear();
                    
                }

                else
                {
                    queue.Enqueue(input);
                    
                }
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
