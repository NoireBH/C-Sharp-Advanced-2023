using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumber = new HashSet<string>();

            string input;
            while ((input = Console.ReadLine())!= "END")
            {
                string[] cmd = input.Split(", ");
                string command = cmd[0];
                string number = cmd[1];

                if (command == "IN")
                {
                    carNumber.Add(number);
                }

                else if (command == "OUT")
                {
                    carNumber.Remove(number);
                }
            }
            if (carNumber.Count > 0)
            {
                foreach (var numberOfCar in carNumber)
                {
                    Console.WriteLine(numberOfCar);
                }
            }

            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
          
        }
    }
}
