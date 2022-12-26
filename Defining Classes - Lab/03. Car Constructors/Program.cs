using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "BMW";
            car.Model = "MK4";
            car.Year = 1984;
            car.FuelQuantity = 100;
            car.FuelConsumption = 0.3;
            car.Drive(400);
            Console.WriteLine(car.WhoAmI());

        }
    }
}
