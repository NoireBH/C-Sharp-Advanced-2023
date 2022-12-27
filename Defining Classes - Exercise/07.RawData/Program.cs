using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] data = Console.ReadLine().Split();
                string model = data[0];
                int engineSpeed = int.Parse(data[1]);
                int enginePower = int.Parse(data[2]);
                int cargoWeight = int.Parse(data[3]);
                string cargoType = data[4];
                double tire1Pressure = double.Parse(data[5]);
                int tire1Age = int.Parse(data[6]);
                double tire2Pressure = double.Parse(data[7]);
                int tire2Age = int.Parse(data[8]);
                double tire3Pressure = double.Parse(data[9]);
                int tire3Age = int.Parse(data[10]);
                double tire4Pressure = double.Parse(data[11]);
                int tire4Age = int.Parse(data[12]);
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Tyre[] tires = new Tyre[]
                {
                    new Tyre(tire1Age,tire1Pressure),
                    new Tyre(tire2Age,tire2Pressure),
                    new Tyre(tire3Age,tire3Pressure),
                    new Tyre(tire4Age,tire4Pressure)
                };

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);

            }

            string typeOfCargo = Console.ReadLine();
            if (typeOfCargo == "fragile")
            {
                List<Car> filteredByTires = cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(p => p.Pressure < 1)).ToList();

                foreach (var car in filteredByTires)
                {
                    Console.WriteLine(car.Model);
                }
            }

            else if (typeOfCargo == "flammable")
            {
                List<Car> filteredByCargo = cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250).ToList();

                foreach (var car in filteredByCargo)
                {
                    Console.WriteLine(car.Model);
                }
            }
            
        }
    }
}
