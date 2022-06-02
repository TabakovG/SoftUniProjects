using System;
using System.Collections.Generic;
using System.Text;
using CarManufacturer;

namespace CarManufacturer
{
    internal class Car
    {
        string make;
        string model;
        int year;
        double fuelQuantity;
        double fuelConsumption;
        Engine engine;
        Tire[] tires;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }


        public void Drive(double distance)
        {
            if (this.FuelQuantity - this.FuelConsumption/100*distance > 0)
            {
                this.FuelQuantity -= this.FuelConsumption/100 * distance;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return
                $"Make: {this.Make}\r\n" +
                $"Model: {this.Model}\r\n" +
                $"Year: {this.Year}\r\n" +
                $"Fuel: {this.FuelQuantity:f2}";
        }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;

        }

        public Car(string make, string model, int year, double fuelQ, double fuelC) : this(make, model, year)
        {
            this.FuelQuantity = fuelQ;
            this.FuelConsumption = fuelC;
        }

        public Car(string make, string model, int year, double fuelQ, double fuelC, Engine engine, Tire[] tires) : this(make, model, year)
        {
            this.FuelQuantity = fuelQ;
            this.FuelConsumption = fuelC;
            this.Engine = engine;
            this.Tires = tires;
        }
    }
}
