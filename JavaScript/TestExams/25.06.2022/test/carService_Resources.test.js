const { assert } = require('chai');
let carService = require('../carService_Resources');

describe("Tests for carService", function () {
    describe("Testing methods availability", function () {

        it("should have isItExpensive method", function () {
            assert.isTrue(carService.hasOwnProperty('isItExpensive'))
        });
        it("should have discount method", function () {
            assert.isTrue(carService.hasOwnProperty('discount'))
        });
        it("should have partsToBuy method", function () {
            assert.isTrue(carService.hasOwnProperty('partsToBuy'))
        });
    });

    describe('tests for isItExpensive', () => {
        it('should return correct result - will cost more - engine', () => {
            let actual = carService.isItExpensive('Engine');
            assert.equal(actual, `The issue with the car is more severe and it will cost more money`);
        });
        it('should return correct result - will cost more - Transmission', () => {
            let actual = carService.isItExpensive('Transmission');
            assert.equal(actual, `The issue with the car is more severe and it will cost more money`);
        });
        it('should return correct result - will cost less - test', () => {
            let actual = carService.isItExpensive('test');
            assert.equal(actual, `The overall price will be a bit cheaper`);
        });
        it('should return correct result - will cost less - t', () => {
            let actual = carService.isItExpensive('t');
            assert.equal(actual, `The overall price will be a bit cheaper`);
        });
    });

    describe('tests for discount - 0 parts', () => {
        it('should return no discount', () => {
            let actual = carService.discount(0, 14);
            assert.equal(actual, "You cannot apply a discount");
        });
        it('should return 0 discount', () => {
            let actual = carService.discount(10, 0);
            assert.equal(actual, `Discount applied! You saved 0$`);
        });
        it('should return no discount - 2 parts', () => {
            let actual = carService.discount(2, 14);
            assert.equal(actual, "You cannot apply a discount");
        });
        it('should return 15% discount - 3 parts', () => {
            let actual = carService.discount(3, 100);
            assert.equal(actual, `Discount applied! You saved 15$`);
        });
        it('should return 15% discount - 7 parts', () => {
            let actual = carService.discount(7, 1000);
            assert.equal(actual, `Discount applied! You saved 150$`);
        });
        it('should return 30% discount - 8 parts', () => {
            let actual = carService.discount(8, 100);
            assert.equal(actual, `Discount applied! You saved 30$`);
        });
        it('should return 30% discount - 22 parts', () => {
            let actual = carService.discount(22, 1000);
            assert.equal(actual, `Discount applied! You saved 300$`);
        });
        it('should throw an error if input not a number - string', () => {
            assert.throw(() => { carService.discount('22', 1000) }, "Invalid input")
        });
        it('should throw an error if input not a number - array', () => {
            assert.throw(() => { carService.discount([3], 1000) }, "Invalid input")
        });
        it('should throw an error if input not a number - bool', () => {
            assert.throw(() => { carService.discount(22, false) }, "Invalid input")
        });
        it('should throw an error if input not a number - obj', () => {
            assert.throw(() => { carService.discount({}, 1000) }, "Invalid input")
        });
        it('should throw an error if input not a number - str', () => {
            assert.throw(() => { carService.discount(10, '344') }, "Invalid input")
        });
        it('should throw an error if input not a number - arr', () => {
            assert.throw(() => { carService.discount(10, [4]) }, "Invalid input")
        });

    });
    describe('tests for partsToBuy', () => {

        let catalog = [
            { part: 'p1', price: 10 },
            { part: 'p2', price: 20 },
            { part: 'p3', price: 30 },
            { part: 'p4', price: 40 }];
        let example = ['p1', 'p6'];


        it('should return correct result - 0 ', () => {
            //Arrange
            let neededParts = ['p5', 'p6'];
            //Act
            let actual = carService.partsToBuy(catalog, neededParts);
            //Assert
            assert.equal(actual, 0);
        });
        it('should return correct result - 0 ', () => {
            //Arrange
            let neededParts = [];

            //Act
            let actual = carService.partsToBuy(catalog, neededParts);
            //Assert
            assert.equal(actual, 0);
        });
        it('should return correct result - 10 ', () => {
            //Arrange
            let neededParts = ['p1', 'p6'];
            //Act
            let actual = carService.partsToBuy(catalog, neededParts);
            //Assert
            assert.equal(actual, 10);
        });
        it('should return correct result - 30 ', () => {
            //Arrange
            let neededParts = ['p1', 'p2'];
            //Act
            let actual = carService.partsToBuy(catalog, neededParts);
            //Assert
            assert.equal(actual, 30);
        });
        it('should return correct result - 60 ', () => {
            //Arrange
            let neededParts = ['p3', 'p1', 'p2'];
            //Act
            let actual = carService.partsToBuy(catalog, neededParts);
            //Assert
            assert.equal(actual, 60);
        });
        it('should throw an error if input not an arr - str', () => {
            assert.throw(() => { carService.partsToBuy(catalog, 'p1, p2') }, "Invalid input")
        });
        it('should throw an error if input not an arr - str', () => {
            assert.throw(() => { carService.partsToBuy('p1, p2',example) }, "Invalid input")
        });
        it('should throw an error if input not an arr - num', () => {
            assert.throw(() => { carService.partsToBuy(catalog, 22) }, "Invalid input")
        });
        it('should throw an error if input not an arr - num', () => {
            assert.throw(() => { carService.partsToBuy(22,example) }, "Invalid input")
        });
        it('should throw an error if input not an arr - undefined', () => {
            assert.throw(() => { carService.partsToBuy(catalog) }, "Invalid input")
        });
        it('should throw an error if input not an arr - undefined', () => {
            assert.throw(() => { carService.partsToBuy(undefined, example) }, "Invalid input")
        });

    });
});
