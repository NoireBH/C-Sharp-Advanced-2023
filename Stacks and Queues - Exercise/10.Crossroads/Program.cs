using System;
using System.Collections.Generic;
using System.Text;

namespace _10.Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var trafficQueue = new Queue<string>();
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            var passingCar = new StringBuilder();
            int carsThatPassed = 0;

            string input;
            while ((input = Console.ReadLine())!= "END")
            {
                if (input == "green")
                {
                    if (trafficQueue.Count == 0)
                    {
                        continue;
                    }

                    passingCar = new StringBuilder(trafficQueue.Peek());

                    for (int i = 0; i < greenLightDuration; i++)
                    {
                        
                         passingCar.Remove(0, 1);

                        if (passingCar.Length == 0)
                        {   
                            carsThatPassed++;
                            trafficQueue.Dequeue();

                            if (trafficQueue.Count > 0)
                            {
                                passingCar = new StringBuilder(trafficQueue.Peek());
                            }

                            else
                            {
                                break;
                            }
                        }
                    }

                    if (passingCar.Length > 0)
                    {
                        for (int i = 0; i < freeWindowDuration; i++)
                        {
                            passingCar.Remove(0, 1);

                            if (passingCar.Length == 0)
                            {
                                carsThatPassed++;
                                trafficQueue.Dequeue();
                                break;
                            }
                        }

                        if (passingCar.Length > 0)
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{trafficQueue.Peek()} was hit at {passingCar[0]}.");
                            return;
                        }
                    }       

                }
                else
                {
                    string car = input;
                    trafficQueue.Enqueue(car);
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carsThatPassed} total cars passed the crossroads.");

        }
    }
}
