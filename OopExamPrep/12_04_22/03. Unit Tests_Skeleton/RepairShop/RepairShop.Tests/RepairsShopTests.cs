using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace RepairShop.Tests
{
    public class Tests
    {
        [TestFixture]
        public class RepairsShopTests
        {
            //Car Tests
            [Test]
            public void CarConstructorShouldCreateCar()
            {
                //Arrange

                var car = new Car("Opel", 12);
                var car2 = new Car("Skoda", 0);

                //Act
                //Assert
                Assert.That(car, Is.Not.Null);
                Assert.That(car.CarModel, Is.EqualTo("Opel"));
                Assert.That(car.NumberOfIssues, Is.EqualTo(12));
                Assert.That(car.IsFixed, Is.False);
                Assert.That(car2.IsFixed, Is.True);

            }

            //RepairShop Test

            [Test]
            public void GarageConstructorShouldCreateGarage()
            {
                //Arrange

                var garage = new Garage("Eurotek", 33);

                //Act
                //Assert

                Assert.That(garage, Is.Not.Null);
                Assert.That(garage.Name, Is.EqualTo("Eurotek"));
                Assert.That(garage.MechanicsAvailable, Is.EqualTo(33));
            }

            [TestCase(null)]
            [TestCase("")]

            public void GarageNameShouldThrowExceptionOnNullOrEmpty(string name)
            {
                //Arrange
                //Act
                //Assert
                Assert.Throws<ArgumentNullException>(
                    () => new Garage(name, 33), "Invalid garage name.");
            }

            [TestCase(0)]
            [TestCase(-1)]
            [TestCase(-12)]
            public void GarageMechanicsAvailableShouldThrowExceptionOnNegativeOrZero(int num)
            {
                //Arrange
                //Act
                //Assert
                Assert.Throws<ArgumentException>(
                    () => new Garage("Eurotek", num), "At least one mechanic must work in the garage.");
            }
            [Test]
            public void CarsInGarageShouldCreateRturnCarsCount()
            {
                //Arrange

                var garage = new Garage("Eurotek", 33);
                Assert.That(garage.CarsInGarage, Is.EqualTo(0));

                //Act
                garage.AddCar(new Car("test", 2));
                garage.AddCar(new Car("test2", 22));
                //Assert

                Assert.That(garage.CarsInGarage, Is.EqualTo(2));
            }

            [Test]
            public void AddCarShouldAddCarToGarage()
            {
                //Arrange

                var garage = new Garage("Eurotek", 33);
                Car car = new Car("test", 2);
                Car car2 = new Car("test2", 1);

                var expected = new List<Car>
                {
                    car,
                    car2
                };

                //Act
                garage.AddCar(car);
                garage.AddCar(car2);

                var type = garage.GetType();
                var cars = type.GetField("cars", BindingFlags.NonPublic | BindingFlags.Instance);
                var actualList = (List<Car>)cars.GetValue(garage);
                //Assert

                Assert.That(garage.CarsInGarage, Is.EqualTo(2));
                CollectionAssert.AreEqual(expected, actualList);
            }

            [Test]

            public void AddCarShouldThrowExceptionOnNoFreeMechanic()
            {
                //Arrange

                var garage = new Garage("Eurotek", 1);
                Car car = new Car("test", 2);
                Car car2 = new Car("test2", 1);


                //Act
                garage.AddCar(car);

                //Assert

                Assert.Throws<InvalidOperationException>(
                    () => garage.AddCar(car2), "No mechanic available."
                    );
            }
            [Test]
            public void FixCarShouldZeroTheCarIssues()
            {
                //Arrange

                var garage = new Garage("Eurotek", 21);
                Car car = new Car("test", 2);
                Car car2 = new Car("test2", 1);


                //Act
                garage.AddCar(car);
                garage.AddCar(car2);

                garage.FixCar("test");

                //Assert

                Assert.That(car.NumberOfIssues, Is.EqualTo(0));
                Assert.That(car.IsFixed, Is.True);
            }

            [Test]
            public void FixCarShouldThrowExceptionOnInvalidCarName()
            {
                //Arrange

                var garage = new Garage("Eurotek", 21);
                Car car = new Car("test", 2);

                var garage2 = new Garage("Eurotek", 21);

                string carName = "InvalidCarName";
                //Act

                garage.AddCar(car);


                //Assert

                Assert.Throws<InvalidOperationException>(
                    () => garage.FixCar(carName), $"The car {carName} doesn't exist.");
                Assert.Throws<InvalidOperationException>(
                    () => garage2.FixCar(carName), $"The car {carName} doesn't exist.");

            }
            [Test]
            public void RemoveFixedCarShouldRemoveCarFromTheGarage()
            {
                //Arrange

                var garage = new Garage("Eurotek", 21);
                Car car = new Car("test", 2);
                Car car2 = new Car("test2", 22);

                //Act

                garage.AddCar(car);
                garage.AddCar(car2);
                garage.FixCar("test");
                garage.RemoveFixedCar();

                //Assert

                Assert.That(garage.CarsInGarage, Is.EqualTo(1));

            }
            [Test]
            public void RemoveFixedCarShouldThrowExceptionOnNoFixedCars()
            {
                //Arrange

                var garage = new Garage("Eurotek", 21);
                Car car = new Car("test", 2);
                Car car2 = new Car("test2", 22);

                //Act
                garage.AddCar(car);
                garage.AddCar(car2);
                //Assert

                Assert.Throws<InvalidOperationException>(
                   () => garage.RemoveFixedCar(), "No fixed cars available.");

            }

            [Test]
            public void ReportShouldReturnNonFixedCars()
            {
                //Arrange

                var garage = new Garage("Eurotek", 21);
                Car car = new Car("test", 2);
                Car car2 = new Car("test2", 22);
                Car car3 = new Car("test3", 33);

                //Act
                garage.AddCar(car);
                garage.AddCar(car2);
                garage.AddCar(car3);
                garage.FixCar("test");

                var expected = "There are 2 which are not fixed: test2, test3.";

                //Assert
                Assert.That(garage.Report(), Is.EqualTo(expected));

            }

        }
    }
}