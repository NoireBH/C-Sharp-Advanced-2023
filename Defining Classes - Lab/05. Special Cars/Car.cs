﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{

    
    

        public class Car
        {   
           
            public Car()
            {
                Make = "VW";
                Model = "Golf";
                Year = 2025;
                FuelQuantity = 200;
                FuelConsumption = 10;


            }

            public Car(string make, string model, int year) : this()
            {
                Make = make;
                Model = model;
                Year = year;
            }

            public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
            {
                FuelConsumption = fuelConsumption;
                FuelQuantity = fuelQuantity;
            }

            public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,
                Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
            {
                Engine = engine;
                Tires = tires;
            }

            private string make;
            private string model;
            private int year;
            private double fuelQuantity;
            private double fuelConsumption;
            private Engine engine;
            private Tire[] tires;
            


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
            public Engine Engine { get { return engine; } set { engine = value; } }
            public Tire[] Tires { get { return tires; } set { tires = value; } }

            public void Drive(double distance)
            {
                double leftFuel = FuelQuantity - (fuelConsumption * distance);


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

