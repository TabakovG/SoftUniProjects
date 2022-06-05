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

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }


        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        public Parking(int capacity)
        {
            this.Cars = new List<Car>();
            this.Capacity = capacity;
        }

        public string AddCar(Car car)
        {
            if (cars.FirstOrDefault(c=>c.RegistrationNumber == car.RegistrationNumber) != null)
            {
                return "Car with that registration number, already exists!";
            }
            else if (cars.Count >= capacity)
            {
                return "Parking is full!";
            }
            else
            {
                cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string RegistrationNumber)
        {
            var carToRemove = cars.FirstOrDefault(c => c.RegistrationNumber == RegistrationNumber);
            if (carToRemove == null)
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                cars.Remove(carToRemove);
                return $"Successfully removed {RegistrationNumber}";
            }
        }

        public Car GetCar(string RegistrationNumber)
        { 
            Car car = cars.FirstOrDefault(c => c.RegistrationNumber == RegistrationNumber);
            return car;
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var reg in RegistrationNumbers)
            {
                Car carToRemove = cars.FirstOrDefault(c => c.RegistrationNumber == reg);
                if (carToRemove != null)
                {
                    RemoveCar(reg);
                }
            }
        }

        public int Count
        {
            get { return cars.Count; }
        }

    }
}
