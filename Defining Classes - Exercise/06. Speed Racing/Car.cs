using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Speed_Racing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionFor1km)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionFor1km;
        }

        public string Model { get { return model; } set { model = value; } }    
        public double FuelAmount { get { return fuelAmount; } set { fuelAmount = value; } }
        public double FuelConsumptionPerKilometer { get { return fuelConsumptionPerKilometer; } set { fuelConsumptionPerKilometer = value; } }
        public double TravelledDistance { get { return travelledDistance; } set { travelledDistance = value; } }

        public void Drive(int amountOfKm)
        {
            double neededLiters = amountOfKm * FuelConsumptionPerKilometer;
            if (FuelAmount >= neededLiters)
            {
                FuelAmount -= neededLiters;
                TravelledDistance += amountOfKm;
            }

            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
