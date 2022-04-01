using System;
using System.Collections.Generic;

namespace Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split("|");
                cars[carInfo[0]] = new Car(carInfo[0], int.Parse(carInfo[1]), int.Parse(carInfo[2]));
            }
            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] cmd = command.Split(" : ");
                string action = cmd[0];
                string carType = cmd[1];

                switch (action)
                {
                    case "Drive":
                        int distance = int.Parse(cmd[2]);
                        int fuelNeeded = int.Parse(cmd[3]);

                        if (fuelNeeded > cars[carType].Fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            cars[carType].Fuel -= fuelNeeded;
                            cars[carType].Mileage += distance;

                            Console.WriteLine($"{carType} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");
                            if (cars[carType].Mileage >= 100000)
                            {
                                cars.Remove(carType);
                                Console.WriteLine($"Time to sell the {carType}!");
                            }
                        }

                        break;
                    case "Refuel":
                        int addFuel = int.Parse(cmd[2]);
                        if (cars[carType].Fuel + addFuel > 75)
                        {
                            addFuel = 75 - cars[carType].Fuel;
                        }
                        cars[carType].Fuel += addFuel;

                        Console.WriteLine($"{carType} refueled with {addFuel} liters");
                        break;
                    case "Revert":
                        int revertAmount = int.Parse(cmd[2]);
                        if (cars[carType].Mileage - revertAmount < 10000)
                        {
                            cars[carType].Mileage = 10000;
                        }
                        else
                        {
                            cars[carType].Mileage -= revertAmount;
                            Console.WriteLine($"{carType} mileage decreased by {revertAmount} kilometers");
                        }
                        break;

                }
                command = Console.ReadLine();
            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value.Mileage} kms, Fuel in the tank: {item.Value.Fuel} lt.");
            }
        }
    }
    class Car
    {
        public string Type { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }

        public Car(string type, int mileage, int fuel)
        {
            this.Type = type;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }
    }
}
