using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            string input;
            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tireInfo = input.Split();
                var currentTires = new Tire[4];
                int count = 0;

                for (int i = 0; i < tireInfo.Length; i +=2)
                {
                    int year = int.Parse(tireInfo[i]);
                    double pressure = double.Parse(tireInfo[i + 1]);
                    Tire tire = new Tire(year, pressure);
                    currentTires[count] = tire;
                    count++;
                }

                tires.Add(currentTires);

                
                

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
            while ((input3 = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = input3.Split();
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);
                cars.Add(car);
            }

            var specialCars = cars.Where(x => x.Year >= 2017
            && x.Engine.HorsePower > 330
            && (x.Tires.Sum(p => p.Pressure) <= 10)).ToList();

            foreach (var car in specialCars)
            {
                car.Drive(20);
            }
            foreach (var car in specialCars)
            {
                Console.WriteLine($"Make: {car.Make}" +
                    $"\nModel: {car.Model}" +
                    $"\nYear: {car.Year}" +
                    $"\nHorsePowers: {car.Engine.HorsePower}\n" +
                    $"FuelQuantity: {car.FuelQuantity}"
);
            }
            
        }
    }
}
