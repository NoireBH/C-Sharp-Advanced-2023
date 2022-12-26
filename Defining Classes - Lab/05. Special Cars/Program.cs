using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire> tires = new List<Tire>();
            List<Engine> engines = new List<Engine>();

            string input;
            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tireInfo = input.Split();
                int year = int.Parse(tireInfo[0]);
                double pressure = double.Parse(tireInfo[1]);
                Tire tire = new Tire(year, pressure);
                tires.Add(tire);

            }

            string input2;
            while ((input2 = Console.ReadLine()) != "Engines done")
            {
                string[] tireInfo = input2.Split();
                int horsePower = int.Parse(tireInfo[0]);
                double cubicCapacity = double.Parse(tireInfo[1]);
                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);

            }

            string input3;
            while ((input3 = Console.ReadLine()) != "Engines done")
            {

            }
        }
    }
}
