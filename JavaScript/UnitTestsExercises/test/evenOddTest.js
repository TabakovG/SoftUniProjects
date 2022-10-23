const { assert } = require('chai');
const { describe } = require('mocha');
const isOddOrEven = require('../evenOrOdd');

describe('even or odd function tests', ()=>{
    it('should return undefined if input is not a string ', ()=>{
        //arrange
        //act
        //assert
        assert.equal(isOddOrEven(0), undefined);
        assert.equal(isOddOrEven([0,1]), undefined);
        assert.equal(isOddOrEven({}), undefined);
        assert.equal(isOddOrEven(true), undefined);
    });
    it('should return odd if input is odd string ', ()=>{
        //arrange
        let input = 'someOddString'
        //act
        let actual = isOddOrEven(input);
        //assert
        assert.equal(actual, 'odd');
    });
    it('should return odd if input is odd string ', ()=>{
        //arrange
        let input = 's'
        //act
        let actual = isOddOrEven(input);
        //assert
        assert.equal(actual, 'odd');
    });
    it('should return even if input is even string ', ()=>{
        //arrange
        let input = 'so'
        //act
        let actual = isOddOrEven(input);
        //assert
        assert.equal(actual, 'even');
    });
    it('should return even if input is even string ', ()=>{
        //arrange
        let input = 'someEvenString'
        //act
        let actual = isOddOrEven(input);
        //assert
        assert.equal(actual, 'even');
    });
});