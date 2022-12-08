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

            for (int i = 1; i <= orderQuantity.Length; i++)
            {          
                if (quantityOfFood >= queue.Peek())
                {
                    quantityOfFood -= queue.Peek();
                    queue.Dequeue();
                }

                else
                {
                    break;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }

            else
            {
                Console.WriteLine("Orders left: " + String.Join(" ", queue));
            }         
        }
    }
}
