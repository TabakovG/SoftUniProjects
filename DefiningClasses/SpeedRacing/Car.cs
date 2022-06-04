using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double distanceTraveled;

        public double DistanceTraveled
        {
            get { return distanceTraveled; }
            set { distanceTraveled = value; }
        }


        public double FuelConsumptionPerKilometer
        {
            get { return fuelConsumptionPerKilometer; }
            set { fuelConsumptionPerKilometer = value; }
        }

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Car(string model,
                   double fuelAmount,
                   double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.DistanceTraveled = 0;
        }

        public void TryTravel(double distance) 
        {
            if (this.FuelAmount/this.FuelConsumptionPerKilometer >= distance)
            {
                this.DistanceTraveled += distance;
                this.FuelAmount -= distance*this.FuelConsumptionPerKilometer;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

    }
}
