using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Speed_Racing
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] data = Console.ReadLine().Split();
                string model = data[0];
                double fuelAmount = double.Parse(data[1]);
                double fuelConsumption = double.Parse(data[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(car);
             
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split();
                string carModel = data[1];
                int amountOfKm = int.Parse(data[2]);

                Car carToDrive = cars.First(car => car.Model == carModel);
                carToDrive.Drive(amountOfKm);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
