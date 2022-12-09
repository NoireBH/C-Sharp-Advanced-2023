using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPetrolPumps = int.Parse(Console.ReadLine());
            var pumpQueue = new Queue<Pump>();
            for (int i = 0; i <= numberOfPetrolPumps - 1; i++)
            {
                int[] pumpInfo = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int amount = pumpInfo[0];
                int distance = pumpInfo[1];
                Pump pump = new Pump(amount, distance);
                pumpQueue.Enqueue(pump);
            }
            int startIndex = 0;

                while (true)
                {
                    int currentPetrol = 0;

                    foreach (var truckInfo in pumpQueue)
                    {
                        currentPetrol += truckInfo.amount;
                        currentPetrol -= truckInfo.distance;

                        if (currentPetrol < 0)
                        {
                            Pump element = pumpQueue.Dequeue();
                            pumpQueue.Enqueue(element);
                        startIndex++;
                            break;
                        }

                       
                    }

                    if (currentPetrol >= 0)
                    {
                        Console.WriteLine(startIndex);
                        break;
                    }
                }
                
            
        }

        class Pump
        {           
            public int amount;
            public int distance;

            public Pump(int amount, int distance)
            {              
                this.amount = amount;
                this.distance = distance;
            }
        }
    }
}
