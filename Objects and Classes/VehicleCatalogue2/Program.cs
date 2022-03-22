using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] token = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Vehicle newVeh = new Vehicle(token[0], token[1], token[2], double.Parse(token[3]));

                vehicles.Add(newVeh);

                command = Console.ReadLine();
            }
            if (vehicles.Count > 0)
            {
                string search = Console.ReadLine();
                while (search != "Close the Catalogue")
                {
                    Vehicle selectedV = vehicles.FirstOrDefault(x => x.Model == search);
                    if (selectedV != null)
                    {
                        Console.WriteLine($"Type: {(selectedV.Type == "car" ? "Car" : "Truck")}");
                        Console.WriteLine($"Model: {selectedV.Model}");
                        Console.WriteLine($"Color: {selectedV.Color}");
                        Console.WriteLine($"Horsepower: {selectedV.HorsePower}");
                    }
                    search = Console.ReadLine();
                }

                List<double> carsAvPower = new List<double>();
                List<double> trucksAvPower = new List<double>();
                foreach (var item in vehicles)
                {
                    if (item.Type == "car")
                    {
                        carsAvPower.Add(item.HorsePower);
                    }
                    else
                    {
                        trucksAvPower.Add(item.HorsePower);
                    }
                }
                if (carsAvPower.Count == 0)
                {
                    Console.WriteLine($"Cars have average horsepower of: {0:f2}.");

                }
                else
                {
                    Console.WriteLine($"Cars have average horsepower of: {carsAvPower.Average():f2}.");
                }
                if (trucksAvPower.Count == 0)
                {
                    Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
                }
                else
                {
                    Console.WriteLine($"Trucks have average horsepower of: {trucksAvPower.Average():f2}.");
                }
            }
        }
    }

    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public Vehicle(string type, string model, string color, double power)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = power;
        }

    }


}
