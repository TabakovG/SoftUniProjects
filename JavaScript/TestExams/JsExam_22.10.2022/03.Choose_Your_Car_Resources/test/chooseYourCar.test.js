const { assert } = require('chai');
let chooseYourCar = require('../chooseYourCar');

describe("Tests for chooseYourCar object", function () {
    describe("Tests for choosingType method", function () {
        it("Should return meet the requirements response on valid input 2010", function () {
            //Arrange
            let expected = "This blue Sedan meets the requirements, that you have.";
            //Act
            let actual = chooseYourCar.choosingType('Sedan', 'blue', 2010);
            //Assert
            assert.equal(actual, expected);
        });
        it("Should return meet the requirements response on valid input 2020", function () {
            //Arrange
            let expected = "This blue Sedan meets the requirements, that you have.";
            //Act
            let actual = chooseYourCar.choosingType('Sedan', 'blue', 2020);
            //Assert
            assert.equal(actual, expected);
        });
        it("Should return meet the requirements response on valid input 2022", function () {
            //Arrange
            let expected = "This blue Sedan meets the requirements, that you have.";
            //Act
            let actual = chooseYourCar.choosingType('Sedan', 'blue', 2022);
            //Assert
            assert.equal(actual, expected);
        });


        it("Should return not for you response on valid input 2009", function () {
            //Arrange
            let expected = `This Sedan is too old for you, especially with that blue color.`;
            //Act
            let actual = chooseYourCar.choosingType('Sedan', 'blue', 2009);
            //Assert
            assert.equal(actual, expected);
        });
        it("Should return not for you response on valid input 1900", function () {
            //Arrange
            let expected = `This Sedan is too old for you, especially with that blue color.`;
            //Act
            let actual = chooseYourCar.choosingType('Sedan', 'blue', 1900);
            //Assert
            assert.equal(actual, expected);
        });
        it("Should throw error on invalid input 1899", function () {
            //Assert
            assert.throw(() => { chooseYourCar.choosingType('Sedan', 'blue', 1899) }, `Invalid Year!`);
        });
        it("Should throw error on invalid input -1", function () {
            //Assert
            assert.throw(() => { chooseYourCar.choosingType('Sedan', 'blue', -1) }, `Invalid Year!`);
        });
        it("Should throw error on invalid input 0", function () {
            //Assert
            assert.throw(() => { chooseYourCar.choosingType('Sedan', 'blue', 0) }, `Invalid Year!`);
        });
        it("Should throw error on invalid type combi", function () {
            //Assert
            assert.throw(() => { chooseYourCar.choosingType('combi', 'blue', 2020) }, `This type of car is not what you are looking for.`);
        });
        it("Should throw error on invalid type sedan", function () {
            //Assert
            assert.throw(() => { chooseYourCar.choosingType('sedan', 'blue', 2020) }, `This type of car is not what you are looking for.`);
        });
        it("Should throw error on invalid type ''", function () {
            //Assert
            assert.throw(() => { chooseYourCar.choosingType('', 'green', 1998) }, `This type of car is not what you are looking for.`);
        });
    });
    describe("Tests for brandName(brands, brandIndex)  method", function () {
        it(`Should return correct string on valid input (["BMW", "Toyota", "Peugeot"], 1)`, function () {
            //Arrange
            let expected = "BMW, Peugeot";
            //Act
            let actual = chooseYourCar.brandName(["BMW", "Toyota", "Peugeot"], 1);
            //Assert
            assert.equal(actual, expected);
        });
        it(`Should return correct string on valid input (["BMW", "Toyota", "Peugeot"], 0)`, function () {
            //Arrange
            let expected = "Toyota, Peugeot";
            //Act
            let actual = chooseYourCar.brandName(["BMW", "Toyota", "Peugeot"], 0);
            //Assert
            assert.equal(actual, expected);
        });
        it(`Should return correct string on valid input (["BMW", "Toyota", "Peugeot"], 2)`, function () {
            //Arrange
            let expected = "BMW, Toyota";
            //Act
            let actual = chooseYourCar.brandName(["BMW", "Toyota", "Peugeot"], 2);
            //Assert
            assert.equal(actual, expected);
        });
        it(`Should return correct string on valid input (["BMW"], 0)`, function () {
            //Arrange
            let expected = "";
            //Act
            let actual = chooseYourCar.brandName(["BMW"], 0);
            //Assert
            assert.equal(actual, expected);
        });
        it(`Should return correct string on valid input (["BMW", "Toyota"], 1)`, function () {
            //Arrange
            let expected = "BMW";
            //Act
            let actual = chooseYourCar.brandName(["BMW", "Toyota"], 1);
            //Assert
            assert.equal(actual, expected);
        });
        it("Should throw error on invalid array - string", function () {
            //Assert
            assert.throw(() => { chooseYourCar.brandName('"BMW", "Toyota"', 1) }, "Invalid Information!");
        });
        it("Should throw error on invalid array - num", function () {
            //Assert
            assert.throw(() => { chooseYourCar.brandName(4, 0) }, "Invalid Information!");
        });
        it("Should throw error on invalid array - bool", function () {
            //Assert
            assert.throw(() => { chooseYourCar.brandName(true, 0) }, "Invalid Information!");
        });
        it("Should throw error on invalid index - string", function () {
            //Assert
            assert.throw(() => { chooseYourCar.brandName(["BMW", "Toyota"], '1') }, "Invalid Information!");
        });
        it("Should throw error on invalid index - float", function () {
            //Assert
            assert.throw(() => { chooseYourCar.brandName(["BMW", "Toyota"], 1.1) }, "Invalid Information!");
        });
        it("Should throw error on invalid index - bool", function () {
            //Assert
            assert.throw(() => { chooseYourCar.brandName(["BMW", "Toyota"], false) }, "Invalid Information!");
        });
        it("Should throw error on invalid index - arr", function () {
            //Assert
            assert.throw(() => { chooseYourCar.brandName(["BMW", "Toyota"], [1]) }, "Invalid Information!");
        });
        it("Should throw error on invalid index - negative", function () {
            //Assert
            assert.throw(() => { chooseYourCar.brandName(["BMW", "Toyota"], -1) }, "Invalid Information!");
        });
        it("Should throw error on invalid index - negative2", function () {
            //Assert
            assert.throw(() => { chooseYourCar.brandName(["BMW", "Toyota"], -21) }, "Invalid Information!");
        });
        it("Should throw error on invalid index - outside", function () {
            //Assert
            assert.throw(() => { chooseYourCar.brandName(["BMW", "Toyota"], 2) }, "Invalid Information!");
        });
        it("Should throw error on invalid index - outside2", function () {
            //Assert
            assert.throw(() => { chooseYourCar.brandName(["BMW", "Toyota"], 22) }, "Invalid Information!");
        });
        it("Should throw error on invalid index - outside zero", function () {
            //Assert
            assert.throw(() => { chooseYourCar.brandName([], 0) }, "Invalid Information!");
        });
    });
    describe("Tests for CarFuelConsumption (distanceInKilometers, consumptedFuelInLitres) method", function () {
        it(`Should return 'The car is efficient enough' on valid input (100, 5)`, function () {
            //Arrange
            let expected = `The car is efficient enough, it burns 5.00 liters/100 km.`;
            //Act
            let actual = chooseYourCar.carFuelConsumption(100, 5);
            //Assert
            assert.equal(actual, expected);
        });
        it(`Should return 'The car is efficient enough' on valid input (100, 7)`, function () {
            //Arrange
            let expected = `The car is efficient enough, it burns 7.00 liters/100 km.`;
            //Act
            let actual = chooseYourCar.carFuelConsumption(100, 7);
            //Assert
            assert.equal(actual, expected);
        });
        
        it(`Should return 'The car is efficient enough' on valid input (100, 0.1)`, function () {
            //Arrange
            let expected = `The car is efficient enough, it burns 0.10 liters/100 km.`;
            //Act
            let actual = chooseYourCar.carFuelConsumption(100, 0.1);
            //Assert
            assert.equal(actual, expected);
        });
        it(`Should return 'The car is efficient enough' on valid input (100, 4.67)`, function () {
            //Arrange
            let expected = `The car is efficient enough, it burns 4.67 liters/100 km.`;
            //Act
            let actual = chooseYourCar.carFuelConsumption(100, 4.67);
            //Assert
            assert.equal(actual, expected);
        });
        it(`Should return 'The car is efficient enough' on valid input (100.15, 4.67)`, function () {
            //Arrange
            let expected = `The car is efficient enough, it burns 4.66 liters/100 km.`;
            //Act
            let actual = chooseYourCar.carFuelConsumption(100.15, 4.67);
            //Assert
            assert.equal(actual, expected);
        });
        it(`Should return 'The car is efficient enough' on valid input (0.120, 0.006)`, function () {
            //Arrange
            let expected = `The car is efficient enough, it burns 5.00 liters/100 km.`;
            //Act
            let actual = chooseYourCar.carFuelConsumption(0.120, 0.006);
            //Assert
            assert.equal(actual, expected);
        });
        it(`Should return 'The car burns too much fuel ' on valid input (0.120, 0.06)`, function () {
            //Arrange
            let expected = `The car burns too much fuel - 50.00 liters!`;
            //Act
            let actual = chooseYourCar.carFuelConsumption(0.120, 0.06);
            //Assert
            assert.equal(actual, expected);
        });
        it(`Should return 'The car burns too much fuel ' on valid input (100, 10)`, function () {
            //Arrange
            let expected = `The car burns too much fuel - 10.00 liters!`;
            //Act
            let actual = chooseYourCar.carFuelConsumption(100, 10);
            //Assert
            assert.equal(actual, expected);
        });
        it(`Should return 'The car burns too much fuel ' on valid input (100, 7.1)`, function () {
            //Arrange
            let expected = `The car burns too much fuel - 7.10 liters!`;
            //Act
            let actual = chooseYourCar.carFuelConsumption(100, 7.1);
            //Assert
            assert.equal(actual, expected);
        });
        it("Should throw error on invalid input - distance zero", function () {
            //Assert
            assert.throw(() => { chooseYourCar.carFuelConsumption(0, 6.1) }, "Invalid Information!");
        });
        it("Should throw error on invalid input - distance zero 2", function () {
            //Assert
            assert.throw(() => { chooseYourCar.carFuelConsumption(0, 7) }, "Invalid Information!");
        });
        it("Should throw error on invalid input - cons zero", function () {
            //Assert
            assert.throw(() => { chooseYourCar.carFuelConsumption(100, 0) }, "Invalid Information!");
        });
        it("Should throw error on invalid input - cons zero 2", function () {
            //Assert
            assert.throw(() => { chooseYourCar.carFuelConsumption(10.80, 0) }, "Invalid Information!");
        });
        it("Should throw error on invalid input - distance negative", function () {
            //Assert
            assert.throw(() => { chooseYourCar.carFuelConsumption(-100, 8) }, "Invalid Information!");
        });
        it("Should throw error on invalid input - cons negative", function () {
            //Assert
            assert.throw(() => { chooseYourCar.carFuelConsumption(10.80, -10) }, "Invalid Information!");
        });
        it("Should throw error on invalid input - distance str", function () {
            //Assert
            assert.throw(() => { chooseYourCar.carFuelConsumption('10.80', 10) }, "Invalid Information!");
        });
        it("Should throw error on invalid input - cons str", function () {
            //Assert
            assert.throw(() => { chooseYourCar.carFuelConsumption(10.80, '10') }, "Invalid Information!");
        });
        it("Should throw error on invalid input - distance arr", function () {
            //Assert
            assert.throw(() => { chooseYourCar.carFuelConsumption([100], 10) }, "Invalid Information!");
        });
        it("Should throw error on invalid input - cons arr", function () {
            //Assert
            assert.throw(() => { chooseYourCar.carFuelConsumption(100, [5.2]) }, "Invalid Information!");
        });
    });
});
