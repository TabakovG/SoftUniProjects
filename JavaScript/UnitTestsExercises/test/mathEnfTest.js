const { assert } = require('chai');
const { describe } = require('mocha');
const mathEnforcer = require('../mathEnf');

describe('math enforcer - add five - test', () => {
    it('should return undefined if param is NaN', () => {
        //arrange
        //act
        //assert
        assert.equal(mathEnforcer.addFive('3'), undefined);
        assert.equal(mathEnforcer.addFive('a'), undefined);
        assert.equal(mathEnforcer.addFive(true), undefined);
        assert.equal(mathEnforcer.addFive([3]), undefined);
        assert.equal(mathEnforcer.addFive({}), undefined);
    });
    it('should return  correct result ', () => {
        //arrange
        //act
        //assert
        assert.equal(mathEnforcer.addFive(-11), -6);
        assert.equal(mathEnforcer.addFive(-1), 4);
        assert.equal(mathEnforcer.addFive(0), 5);
        assert.equal(mathEnforcer.addFive(1), 6);
        assert.equal(mathEnforcer.addFive(11), 16);

        assert.closeTo(mathEnforcer.addFive(-11.1), -6.1, 0.01);
        assert.closeTo(mathEnforcer.addFive(1.1), 6.1, 0.01);
    });
});
describe('math enforcer - subtract ten - test', () => {
    it('should return undefined if param is NaN', () => {
        //arrange
        //act
        //assert
        assert.equal(mathEnforcer.subtractTen('3'), undefined);
        assert.equal(mathEnforcer.subtractTen('a'), undefined);
        assert.equal(mathEnforcer.subtractTen(true), undefined);
        assert.equal(mathEnforcer.subtractTen([3]), undefined);
        assert.equal(mathEnforcer.subtractTen({}), undefined);
    });
    it('should return  correct result ', () => {
        //arrange
        //act
        //assert
        assert.equal(mathEnforcer.subtractTen(-11), -21);
        assert.equal(mathEnforcer.subtractTen(-1), -11);
        assert.equal(mathEnforcer.subtractTen(0), -10);
        assert.equal(mathEnforcer.subtractTen(1), -9);
        assert.equal(mathEnforcer.subtractTen(11), 1);

        assert.closeTo(mathEnforcer.subtractTen(-11.1), -21.1, 0.01);
        assert.closeTo(mathEnforcer.subtractTen(33.1), 23.1, 0.01);
    });
});
describe('math enforcer - sum - test', () => {
    it('should return undefined if any param is NaN', () => {
        //arrange
        //act
        //assert
        assert.equal(mathEnforcer.sum(0, '3'), undefined);
        assert.equal(mathEnforcer.sum(0, 'a'), undefined);
        assert.equal(mathEnforcer.sum(0, true), undefined);
        assert.equal(mathEnforcer.sum(0, [3]), undefined);
        assert.equal(mathEnforcer.sum({}, 0), undefined); assert.equal(mathEnforcer.sum(0, '3'), undefined);
        assert.equal(mathEnforcer.sum('a', 0), undefined);
        assert.equal(mathEnforcer.sum(true, 0), undefined);
        assert.equal(mathEnforcer.sum([3], 0), undefined);
        assert.equal(mathEnforcer.sum({}, 0), undefined);
    });

    it('should return  correct result ', () => {
        //arrange
        //act
        //assert
        assert.equal(mathEnforcer.sum(-11, -12), -23);
        assert.equal(mathEnforcer.sum(-1, 1), 0);
        assert.equal(mathEnforcer.sum(0, 0), 0);
        assert.equal(mathEnforcer.sum(1, -4), -3);
        assert.equal(mathEnforcer.sum(11, 22), 33);

        assert.closeTo(mathEnforcer.sum(-11.1, 10), -1.1, 0.01);
        assert.closeTo(mathEnforcer.sum(33.1, -1.2), 31.9, 0.01);
    });
});