using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {   
            Cars = new List<Car>();
            Capacity = capacity;
        }

        public List<Car> Cars { get { return cars; } set { cars = value; } }
        public int Capacity {get { return capacity; } set { capacity = value; } }
        public int Count { get { return Cars.Count; } }

       

        public string AddCar(Car car)
        {
            bool carCanBeAdded = true;

            foreach (var currentCar in Cars)
            {
                if (currentCar.RegistrationNumber == car.RegistrationNumber)
                {
                    carCanBeAdded = false;
                    return "Car with that registration number, already exists!";
                    
                }
            }

            if (Cars.Count + 1 > Capacity)
            {
                carCanBeAdded = false;
                return "Parking is full!";
                
            }

            if (carCanBeAdded)
            {   
                Cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }

            return "";
        }

        public string RemoveCar(string registrationNumber)
        {
            bool isInParking = false;

            foreach (var car in Cars)
            {
                if (car.RegistrationNumber == registrationNumber)
                {
                    isInParking = true;
                }

            }

            if (!isInParking)
            {
                return "Car with that registration number, already exists!";
            }

            else
            {
                Car carToRemove = Cars.First(car => car.RegistrationNumber == registrationNumber);
                Cars.Remove(carToRemove);
                return $"Successfully removed {registrationNumber}";
            }
           
        }

        public Car GetCar(string registrationNumber)
        {
            return Cars.First(c => c.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var registrationNumber in registrationNumbers)
            {
                RemoveCar(registrationNumber);
            }
        }
    }
}
