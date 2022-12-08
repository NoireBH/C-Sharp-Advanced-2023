using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var traffic = new Queue<string>();
            int carsThatCanPass = int.Parse(Console.ReadLine());
            int carsThatPassed = 0;
            string input;
            while ((input = Console.ReadLine()) !="end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < carsThatCanPass; i++)
                    {
                        if (traffic.Count > 0)
                        {
                            Console.WriteLine($"{traffic.Dequeue()} passed!");
                            carsThatPassed++;
                        }
                       
                    }
                }

                else
                {
                    traffic.Enqueue(input);
                }
            }

            Console.WriteLine($"{carsThatPassed} cars passed the crossroads.");
        }
    }
}
