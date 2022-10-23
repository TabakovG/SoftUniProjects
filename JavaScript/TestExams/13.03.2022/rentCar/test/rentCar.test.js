const { assert } = require('chai');
let rentCar = require('../rentCar');

describe("Tests …", function () {
    describe("searchCar …", function () {
        it("2 skoda", function () {
            //arrange
            let expected = `There is 2 car of model Skoda in the catalog!`;
            //act
            let actual = rentCar.searchCar(['Skoda', 'Audi', 'Skoda', 'skoda'], 'Skoda');
            //assert
            assert.equal(actual, expected);
        });
        it("1 skoda", function () {
            //arrange
            let expected = `There is 1 car of model skoda in the catalog!`;
            //act
            let actual = rentCar.searchCar(['Skoda', 'Audi', 'Skoda', 'skoda'], 'skoda');
            //assert
            assert.equal(actual, expected);
        });
        it("1 skoda", function () {
            //arrange
            let expected = `There is 1 car of model Skoda in the catalog!`;
            //act
            let actual = rentCar.searchCar(['Skoda'], 'Skoda');
            //assert
            assert.equal(actual, expected);
        });
        it("0 VW", function () {
            //assert
            assert.throw(() => { rentCar.searchCar(['Skoda', 'Audi', 'BMW'], 'VW') }, 'There are no such models in the catalog!');
        });
        it("0 VW", function () {
            //assert
            assert.throw(() => { rentCar.searchCar([], 'VW') }, 'There are no such models in the catalog!');
        });
        it("0 audi", function () {
            //assert
            assert.throw(() => { rentCar.searchCar(['Skoda', 'Audi', 'BMW'], 'audi') }, 'There are no such models in the catalog!')
        });
        it("str inp", function () {
            //assert
            assert.throw(() => { rentCar.searchCar('Skoda, Audi, BMW', 'audi') }, 'Invalid input!');
        });
        it("num inp", function () {
            //assert
            assert.throw(() => { rentCar.searchCar(2, 'audi') }, 'Invalid input!');
        });
        it("num inp 2", function () {
            //assert
            assert.throw(() => { rentCar.searchCar(['Skoda', 'Audi', 'BMW'], 2) }, 'Invalid input!');
        });
        it("[] inp", function () {
            //assert
            assert.throw(() => { rentCar.searchCar(['Skoda', 'Audi', 'BMW'], ['audi']) }, 'Invalid input!');
        });
        it("{} inp", function () {
            //assert
            assert.throw(() => { rentCar.searchCar({}, 'audi') }, 'Invalid input!');
        });
        it("{} inp 2", function () {
            //assert
            assert.throw(() => { rentCar.searchCar(['Skoda', 'Audi', 'BMW'], {}) }, 'Invalid input!');
        });
    });
    describe("calculatePriceOfCar (model, days)  …", function () {
        it(" Audi 1 ", function () {
            //arrange
            let expected = `You choose Audi and it will cost $36!`;
            //act
            let actual = rentCar.calculatePriceOfCar('Audi', 1);
            //assert
            assert.equal(actual, expected);
        });
        it(" Audi 2 ", function () {
            //arrange
            let expected = `You choose Audi and it will cost $72!`;
            //act
            let actual = rentCar.calculatePriceOfCar('Audi', 2);
            //assert
            assert.equal(actual, expected);
        });
        it(" Audi 0 ", function () {
            //arrange
            let expected = `You choose Audi and it will cost $0!`;
            //act
            let actual = rentCar.calculatePriceOfCar('Audi', 0);
            //assert
            assert.equal(actual, expected);
        });
        it(" Skoda 1 ", function () {
            assert.throw(() => { rentCar.calculatePriceOfCar('Skoda', 1) }, 'No such model in the catalog!');
        });
        it(" Skoda 0 ", function () {
            assert.throw(() => { rentCar.calculatePriceOfCar('Skoda', 0) }, 'No such model in the catalog!');
        });
        it(" Skoda 1.1 ", function () {
            assert.throw(() => { rentCar.calculatePriceOfCar('Skoda', 1.1) }, 'Invalid input!');
        });
        it(" Audi 1.1 ", function () {
            assert.throw(() => { rentCar.calculatePriceOfCar('Audi', 1.1) }, 'Invalid input!');
        });
        it(" [Audi] 1 ", function () {
            assert.throw(() => { rentCar.calculatePriceOfCar(['Audi'], 1) }, 'Invalid input!');
        });
        it(" true 1 ", function () {
            assert.throw(() => { rentCar.calculatePriceOfCar(true, 1) }, 'Invalid input!');
        });
        it(" Audi true  ", function () {
            assert.throw(() => { rentCar.calculatePriceOfCar('Audi', true) }, 'Invalid input!');
        });
        it(" true [1] ", function () {
            assert.throw(() => { rentCar.calculatePriceOfCar('Audi', [1]) }, 'Invalid input!');
        });
        it(" audi str ", function () {
            assert.throw(() => { rentCar.calculatePriceOfCar('Audi', '1') }, 'Invalid input!');
        });
    });
    describe("checkBudget (costPerDay, days, budget)  …", function () {
        it(" 15 1 555", function () {
            //arrange
            let expected = `You rent a car!`;
            //act
            let actual = rentCar.checkBudget(15, 1, 555);
            //assert
            assert.equal(actual, expected);
        });
        it(" 15 4 555", function () {
            //arrange
            let expected = `You rent a car!`;
            //act
            let actual = rentCar.checkBudget(15, 4, 555);
            //assert
            assert.equal(actual, expected);
        });
        it(" 15 0 1", function () {
            //arrange
            let expected = `You rent a car!`;
            //act
            let actual = rentCar.checkBudget(15, 0, 1);
            //assert
            assert.equal(actual, expected);
        });
        it(" 0 1 1", function () {
            //arrange
            let expected = `You rent a car!`;
            //act
            let actual = rentCar.checkBudget(0, 1, 1);
            //assert
            assert.equal(actual, expected);
        });
        it(" 0 0 1", function () {
            //arrange
            let expected = `You rent a car!`;
            //act
            let actual = rentCar.checkBudget(0, 0, 1);
            //assert
            assert.equal(actual, expected);
        });
        it(" 0 0 0", function () {
            //arrange
            let expected = `You rent a car!`;
            //act
            let actual = rentCar.checkBudget(0, 0, 0);
            //assert
            assert.equal(actual, expected);
        });
        it(" -12 4 50", function () {
            //arrange
            let expected = `You rent a car!`;
            //act
            let actual = rentCar.checkBudget(-12, 4, 50);
            //assert
            assert.equal(actual, expected);
        });
        it(" 12 -4 50", function () {
            //arrange
            let expected = `You rent a car!`;
            //act
            let actual = rentCar.checkBudget(12, -4, 50);
            //assert
            assert.equal(actual, expected);
        });
        it(" 12 -4 0", function () {
            //arrange
            let expected = `You rent a car!`;
            //act
            let actual = rentCar.checkBudget(12, -4, 0);
            //assert
            assert.equal(actual, expected);
        });
        it(" 12 4 0", function () {
            //arrange
            let expected = 'You need a bigger budget!';
            //act
            let actual = rentCar.checkBudget(12, 4, 0);
            //assert
            assert.equal(actual, expected);
        });
        it(" 12 4 20", function () {
            //arrange
            let expected = 'You need a bigger budget!';
            //act
            let actual = rentCar.checkBudget(12, 4, 20);
            //assert
            assert.equal(actual, expected);
        });
        it(" 12.1 4 20 ", function () {
            assert.throw(() => { rentCar.checkBudget(12.1, 4, 20) }, 'Invalid input!');
        });
        it(" 12 4.1 20 ", function () {
            assert.throw(() => { rentCar.checkBudget(12, 4.1, 20) }, 'Invalid input!');
        });
        it(" 12 4 20.1 ", function () {
            assert.throw(() => { rentCar.checkBudget(12, 4, 20.1) }, 'Invalid input!');
        });
        it(" '12' 4 20 ", function () {
            assert.throw(() => { rentCar.checkBudget('12', 4, 20) }, 'Invalid input!');
        });
        it(" 12 '4' 20 ", function () {
            assert.throw(() => { rentCar.checkBudget(12, '4', 20) }, 'Invalid input!');
        });
        it(" 12 4 '20' ", function () {
            assert.throw(() => { rentCar.checkBudget(12, 4, '20') }, 'Invalid input!');
        });
        it(" [12] 4 20 ", function () {
            assert.throw(() => { rentCar.checkBudget([12], 4, 20) }, 'Invalid input!');
        });
        it(" 12 [4] 20 ", function () {
            assert.throw(() => { rentCar.checkBudget(12, [4], 20) }, 'Invalid input!');
        });
        it(" 12 4 [20] ", function () {
            assert.throw(() => { rentCar.checkBudget(12, 4, [20]) }, 'Invalid input!');
        });
    });
});
