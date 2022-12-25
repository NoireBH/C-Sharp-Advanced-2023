using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public  class Car
        {
            private string make;
            private string model;
            private int year;
            private double fuelQuantity;
            private double fuelConsumption;


            public string Make { get { return make; } set { make = value; } }
            public string Model { get { return model; } set { model = value; } }
            public int Year
            {
                get
                {
                    return year;
                }
                set                               //this works too but its more rows
                {
                    year = value;
                }
            }

            public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }

            public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }

            public void Drive(double distance)
            {   
                double leftFuel  = FuelQuantity - (fuelConsumption * distance);
                

                if (leftFuel < 0)
                {
                    Console.WriteLine("Not enough fuel to perform this trip!");
                return;
                }
                    fuelQuantity -= distance * fuelConsumption;
                
                

            }

            public string WhoAmI()
            {
                return $"Make: {this.Make}\nModel: {this.Model}\nFuel: {this.fuelQuantity:F2}";

            }


        }
}
