using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int priceOfSingleBullet = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());

            int[] numberOfBullets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numberOfLocks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int inteligenceValue = int.Parse(Console.ReadLine());
            int moneyDeducted = 0;
            int timesFired = 0;
            var locks = new Queue<int>(numberOfLocks);
            var bullets = new Stack<int>(numberOfBullets);

            while (locks.Count > 0)
            {
                

                if (bullets.Count == 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    return;
                }
              
                if (bullets.Peek() <= locks.Peek())
                {   
                    bullets.Pop();
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                    timesFired++;
                    moneyDeducted += priceOfSingleBullet;
                }

                else if (bullets.Peek() > locks.Peek())
                {
                    bullets.Pop();
                    Console.WriteLine("Ping!");
                    timesFired++;
                    moneyDeducted += priceOfSingleBullet;
                }

                if (timesFired == gunBarrelSize)
                {
                    timesFired = 0;
                    if (bullets.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                    }
                    


                }
            }
            
            Console.WriteLine($"{bullets.Count} bullets left. Earned ${inteligenceValue - moneyDeducted}");


        }
    }
}
