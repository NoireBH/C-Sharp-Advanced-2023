using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kids = new Queue<string>(Console.ReadLine()
                .Split());          
            int numberOfTosses = int.Parse(Console.ReadLine());
            string kidHoldingThePotato = String.Empty;
            while (kids.Count > 1)
            {
                for (int i = 0; i < numberOfTosses - 1; i++)
                {
                    kidHoldingThePotato = kids.Dequeue();
                    kids.Enqueue(kidHoldingThePotato);
                }
                Console.WriteLine($"Removed {kids.Dequeue()}");

            }
            Console.WriteLine($"Last is {kids.Dequeue()}");

        }
    }
}
