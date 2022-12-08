using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] orderQuantity = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var queue = new Queue<int>(orderQuantity);

            int biggestOrder = orderQuantity.Max();
            Console.WriteLine(biggestOrder);

            for (int i = 0; i < queue.Count; i++)
            {          
                if (quantityOfFood >= queue[i])
                {
                    quantityOfFood -= queue[i];
                    queue.Dequeue();
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }

            else
            {
                Console.WriteLine(String.Join(", ", queue));
            }
            
        }
    }
}
