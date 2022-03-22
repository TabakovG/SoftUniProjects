using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Truck> TruckCatalog = new List<Truck>();
            List<Car> CarCatalog = new List<Car>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] token = input.Split("/", StringSplitOptions.RemoveEmptyEntries);

                if (token[0] == "Truck")
                {
                    Truck newTruck = new Truck(token[1], token[2], double.Parse(token[3]));
                    TruckCatalog.Add(newTruck);
                }
                else
                {
                    Car newCar = new Car(token[1], token[2], double.Parse(token[3]));
                    CarCatalog.Add(newCar);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Cars:");
            foreach (var car in CarCatalog.OrderBy(c => c.Brand).ToList())
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (var truck in TruckCatalog.OrderBy(c => c.Brand).ToList())
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }

        }
    }

    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }

        public Truck(string brand, string model, double weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double HorsePower { get; set; }

        public Car (string brand, string model, double power)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = power;
        }
    }

    public class Catalog
    {
        public List<Truck> TruckCatalog { get; set; }
        public List<Car> CarCatalog { get; set; }
    }

}
