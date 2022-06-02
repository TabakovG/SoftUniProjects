using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            /*Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;

            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
            Console.WriteLine();

            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Console.WriteLine(firstCar.WhoAmI());
            Console.WriteLine();

            Car SecondCar = new Car(make, model, year);
            Console.WriteLine(SecondCar.WhoAmI());
            Console.WriteLine();


            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
            Console.WriteLine(thirdCar.WhoAmI());
            Console.WriteLine();

            var tires = new Tire[4]
            {
                new Tire(2008, 2.3),
            new Tire(2008, 2.2),
            new Tire(2008, 2.1),
            new Tire(2008, 2.4)
            };

            var engine = new Engine(560, 6300);
            var fourthCar = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);
            Console.WriteLine(fourthCar.WhoAmI());
            Console.WriteLine();*/

            string input = Console.ReadLine();
            List<Tire[]> tireSets = new List<Tire[]>();

            while (input != "No more tires")
            {
                string[] setInfo = input.Split(" ");

                Tire[] set = new Tire[setInfo.Length / 2];

                set[0] = new Tire(int.Parse(setInfo[0]), double.Parse(setInfo[1]));
                set[1] = new Tire(int.Parse(setInfo[2]), double.Parse(setInfo[3]));
                set[2] = new Tire(int.Parse(setInfo[4]), double.Parse(setInfo[5]));
                set[3] = new Tire(int.Parse(setInfo[6]), double.Parse(setInfo[7]));

                tireSets.Add(set);

                input = Console.ReadLine();
            }

            string inputEngineInfo = Console.ReadLine();
            List<Engine> engines = new List<Engine>();

            while (inputEngineInfo != "Engines done")
            {
                string[] engineInfo = inputEngineInfo.Split(" ");
                engines.Add(
                    new Engine(int.Parse(engineInfo[0]), double.Parse(engineInfo[1]))
                    );

                inputEngineInfo = Console.ReadLine();
            }

            string command = Console.ReadLine();
            List<Car> carsList = new List<Car>();
            while (command != "Show special")
            {
                string[] cmd = command.Split(" ");

                string make = cmd[0];
                string model = cmd[1];
                int year = int.Parse(cmd[2]);
                double fuelQ = double.Parse(cmd[3]);
                double fuelC = double.Parse(cmd[4]);
                Engine engine = engines[int.Parse(cmd[5])];
                Tire[] tires = tireSets[int.Parse(cmd[6])];

                carsList.Add(
                    new Car(make, model, year, fuelQ, fuelC, engine, tires)
                    );

                command = Console.ReadLine();
            }
            var specialCars = carsList
                .FindAll(car => car.Year >= 2017)
                .Where(eng => eng.Engine.HorsePower > 330)
                .Where(tr => tr.Tires.Select(t => t.Pressure).Sum() > 9
                        && tr.Tires.Select(t => t.Pressure).Sum() < 10);
            foreach (var specialCar in specialCars)
            {
                specialCar.Drive(20);

                Console.WriteLine(
                    $"Make: {specialCar.Make}\r\n" +
                    $"Model: {specialCar.Model}\r\n" +
                    $"Year: {specialCar.Year}\r\n" +
                    $"HorsePowers: {specialCar.Engine.HorsePower}\r\n" +
                    $"FuelQuantity: {specialCar.FuelQuantity}");
            }

        }
    }
}

