const { assert } = require('chai');
const createCalculator = require('./addSubtract');

describe('test create calculator function', () => {
    it('should return object', () => {
        //arrange
        let expected = 'object';
        let expectedJson = JSON.stringify({
            add: function (num) { value += Number(num); },
            subtract: function (num) { value -= Number(num); },
            get: function () { return value; }
        });

        //act
        let actual = createCalculator();
        let actualJson = JSON.stringify(actual);

        //assert
        assert.equal(typeof (actual), expected);
        assert.equal(actualJson, expectedJson);

    });
    it('should return object with - get functionality', () => {
        //arrange
        let expected = 0;

        //act
        let actual = createCalculator();
        //assert
        assert.equal(actual.get(), expected);
    });
    it('should return object with - get functionality multi operations', () => {
        //arrange
        let expected = 5;

        //act
        let actual = createCalculator();
        actual.add(10);
        actual.subtract(5);
        actual.add(0);
        //assert
        assert.equal(actual.get(), expected);
    });
    it('should return object with - add functionality working with num', () => {
        //arrange
        let expected = 2;

        //act
        let actual = createCalculator();
        actual.add(2);
        //assert
        assert.equal(actual.get(), expected);
    });
    it('should return object with - add functionality working with num /multiple&mixed', () => {
        //arrange
        let expected = 25;

        //act
        let actual = createCalculator();
        actual.add(2);
        actual.add(2);
        actual.add('21');
        actual.add(0);
        //assert
        assert.equal(actual.get(), expected);
    });
    it('should return object with - add functionality working with negative num', () => {
        //arrange
        let expected = -2;

        //act
        let actual = createCalculator();
        actual.add(-2);
        //assert
        assert.equal(actual.get(), expected);
    });
    it('should return object with - add functionality working with num as string', () => {
        //arrange
        let expected = 2;

        //act
        let actual = createCalculator();
        actual.add('2');
        //assert
        assert.equal(actual.get(), expected);
    });
    it('should return object with - subtract functionality using num', () => {
        //arrange
        let expected = -1;

        //act
        let actual = createCalculator();
        actual.subtract(1);
        //assert
        assert.equal(actual.get(), expected);
    });
    it('should return object with - subtract functionality using num/multiple', () => {
        //arrange
        let expected = -10;

        //act
        let actual = createCalculator();
        actual.subtract(1);
        actual.subtract(0);
        actual.subtract(10);
        actual.subtract(-1);
        //assert
        assert.equal(actual.get(), expected);
    });
    it('should return object with - subtract functionality using num/multiple&mixed', () => {
        //arrange
        let expected = -10;

        //act
        let actual = createCalculator();
        actual.subtract(1);
        actual.subtract(0);
        actual.subtract('10');
        actual.subtract(-1);
        //assert
        assert.equal(actual.get(), expected);
    });
    it('should return object with - subtract functionality using negative num', () => {
        //arrange
        let expected = 10;

        //act
        let actual = createCalculator();
        actual.subtract(-10);
        //assert
        assert.equal(actual.get(), expected);
    });
    it('should return object with - subtract functionality using num as string', () => {
        //arrange
        let expected = -1;

        //act
        let actual = createCalculator();
        actual.subtract('1');
        //assert
        assert.equal(actual.get(), expected);
    });
    it('should return object without direct access to value', () => {
        //arrange
        let expected = undefined;

        //act
        let actual = createCalculator();
        actual.add(2);
        //assert
        assert.equal(actual.value, expected);
    });
});