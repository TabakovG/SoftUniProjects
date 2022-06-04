using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < num; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string engineModel = engineInfo[0];
                int enginePower = int.Parse(engineInfo[1]);


                if (engineInfo.Length == 3)
                {
                    if (int.TryParse(engineInfo[2], out int displacement))
                    {
                        Engine newEngine = new Engine(engineModel, enginePower, displacement);
                        engines.Add(newEngine);
                    }
                    else
                    {
                        Engine newEngine = new Engine(engineModel, enginePower, engineInfo[2]);
                        engines.Add(newEngine);
                    }

                }
                else if (engineInfo.Length == 4)
                {
                    int displacement = int.Parse(engineInfo[2]);
                    string efficiency = engineInfo[3];

                    Engine newEngine = new Engine(engineModel, enginePower, displacement, efficiency);
                    engines.Add(newEngine);
                }
                else
                {
                    Engine newEngine = new Engine(engineModel, enginePower);
                    engines.Add(newEngine);
                }
            }

            int count = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int j = 0; j < count; j++)
            {

                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = carInfo[0];
                Engine carEngine = engines.FirstOrDefault(e => e.Model == carInfo[1]);

                if (carInfo.Length == 3)
                {

                    if (int.TryParse(carInfo[2], out int weight))
                    {
                        Car newCar = new Car(carModel, carEngine, weight);
                        cars.Add(newCar);
                    }
                    else
                    {
                        Car newCar = new Car(carModel, carEngine, carInfo[2]);
                        cars.Add(newCar);
                    }
                }
                else if (carInfo.Length == 4)
                {
                    int weight = int.Parse(carInfo[2]);
                    string color = carInfo[3];

                    Car newCar = new Car(carModel, carEngine, weight, color);
                    cars.Add(newCar);
                }
                else
                {
                    Car newCar = new Car(carModel, carEngine);
                    cars.Add(newCar);
                }
            }

            foreach (var car in cars)
            {
                string checkDspl = car.Engine.Displacement > 0 ? car.Engine.Displacement.ToString() : "n/a";
                string checkWeight = car.Weight > 0 ? car.Weight.ToString() : "n/a";

                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {checkDspl}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {checkWeight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
