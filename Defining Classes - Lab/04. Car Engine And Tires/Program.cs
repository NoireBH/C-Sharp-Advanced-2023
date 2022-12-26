using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new Tire[2]
            {   new Tire(1,2.5),
                new Tire(1,2.1)
            };

            var engine = new Engine(420, 6900);
            var car = new Car("Mazda","Peepo", 2010, 250, 10, engine, tires);

        }
    }
}
