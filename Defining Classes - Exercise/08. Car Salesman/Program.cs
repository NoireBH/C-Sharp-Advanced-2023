using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Car_Salesman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numOfEngines; i++)
            {
                string[] engineData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = engineData[0];
                int power = int.Parse(engineData[1]);

                if (engineData.Length == 3)
                {
                    if (char.IsDigit(engineData[2][0]))
                    {
                        int displacement = int.Parse(engineData[2]);
                        Engine engine = new Engine(model, power, displacement);
                        engines.Add(engine);

                    }
                    else
                    {
                        string efficiency = engineData[2];
                        Engine engine = new Engine(model, power, efficiency);
                        engines.Add(engine);
                    }
                }
                else if (engineData.Length == 4)
                {
                    int displacement = int.Parse(engineData[2]);
                    string efficiency = engineData[3];
                    Engine engine = new Engine(model, power, displacement, efficiency);
                    engines.Add(engine);
                }
                else
                {
                    Engine engine = new Engine(model, power);
                    engines.Add(engine);

                }
            }

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = carData[0];
                string engine = carData[1];
                Engine currentEngine = engines.First(eng => eng.Model == engine);

                if (carData.Length == 3)
                {
                    if (char.IsDigit(carData[2][0]))
                    {
                        int carWeight = int.Parse(carData[2]);
                        Car car = new Car(model, currentEngine, carWeight);
                        cars.Add(car);

                    }
                    else
                    {
                        string carColor = carData[2];
                        Car car = new Car(model, currentEngine, carColor);
                        cars.Add(car);
                    }
                }
                else if (carData.Length == 4)
                {
                    int carWeight = int.Parse(carData[2]);
                    string carColor = carData[3];

                    Car car = new Car(model, currentEngine, carWeight, carColor);
                    cars.Add(car);
                }
                else
                {
                    Car car = new Car(model, currentEngine);
                    cars.Add(car);
                }

            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:\n  {car.Engine.Model}:\n    Power: {car.Engine.Power}");
                if (car.Engine.Displacement == 0)
                {
                    Console.WriteLine("    Displacement: n/a");
                }

                else
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }

                if (car.Engine.Efficiency == @"n/a")
                {
                    Console.WriteLine("    Efficiency: n/a");
                }

                else
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                }

                if (car.Weight == 0)
                {
                    Console.WriteLine("  Weight: n/a");
                }

                else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }

                if (car.Color == @"n/a")
                {
                    Console.WriteLine("  Color: n/a");
                }

                else
                {
                    Console.WriteLine($"    Color: {car.Color}");
                }

            }
        }
    }
}

