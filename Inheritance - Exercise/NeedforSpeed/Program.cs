using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RaceMotorcycle raceMotorcycle = new RaceMotorcycle(100,100);
            SportCar sportCar = new SportCar(100, 100);
            FamilyCar family = new FamilyCar(10, 100);
            sportCar.Drive(9);
            Console.WriteLine(sportCar.Fuel);
            raceMotorcycle.Drive(9);
            Console.WriteLine(raceMotorcycle.Fuel);
            family.Drive(9);
            Console.WriteLine(family.Fuel);
        }
    }
}
