using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string make = input[0];
                double fuel = double.Parse(input[1]);
                double consumption = double.Parse(input[2]);


                if (cars.FirstOrDefault(c => c.Model == make) == null)
                {
                    Car newCar = new Car(make, fuel, consumption);
                    cars.Add(newCar);
                }
            }

            string cmd = Console.ReadLine();

            while (cmd != "End")
            {
                string[] useCar = cmd.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string carModel = useCar[1];
                double distance = double.Parse(useCar[2]);

                Car carToDrive = cars.First(cars => cars.Model == carModel);

                carToDrive.TryTravel(distance);

                cmd = Console.ReadLine();

            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled:f0}");
            }

        }
    }
}
