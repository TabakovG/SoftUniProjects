const { assert } = require('chai');
const { describe } = require('mocha');
const lookupChar = require('../charLookup');

describe('lookupChar function tests', () => {
    it('should return undefined if first param is not a string', () => {
        // //arrange
        // let strParam = 0;
        // let index = 0;
        // //act
        // let actual = lookupChar(strParam, index);
        //assert
        assert.equal(lookupChar(0, 0), undefined);
        assert.equal(lookupChar(false, 0), undefined);
        assert.equal(lookupChar({}, 0), undefined);
        assert.equal(lookupChar([0], 0), undefined);
        assert.equal(lookupChar(['sdsd'], 0), undefined);
        assert.equal(lookupChar(['asd', 'asddd'], 0), undefined);
    });
    it('should return undefined if second param is not a integer', () => {

        //assert
        assert.equal(lookupChar('stringValue', '0'), undefined);
        assert.equal(lookupChar('stringValue', 'asd'), undefined);
        assert.equal(lookupChar('stringValue', 1.2), undefined);
        assert.equal(lookupChar('stringValue', [0]), undefined);
        assert.equal(lookupChar('stringValue', {}), undefined);
        assert.equal(lookupChar('stringValue', ()=>{}), undefined);
    });
    it('should return "Incorrect index" if index out of range', () => {

        //assert
        assert.equal(lookupChar('str', -10), "Incorrect index");
        assert.equal(lookupChar('str', -1), "Incorrect index");
        assert.equal(lookupChar('str', 3), "Incorrect index");
        assert.equal(lookupChar('str', 51), "Incorrect index");

    });
    it('should return char at index', () => {
        //arrange
        let strParam = 'someStr';
        let index1 = 0;
        let index2 = 3;
        let index3 = 6;
        //act
        let actual1 = lookupChar(strParam, index1);
        let actual2 = lookupChar(strParam, index2);
        let actual3 = lookupChar(strParam, index3);
        //assert
        assert.equal(actual1, 's');
        assert.equal(actual2, 'e');
        assert.equal(actual3, 'r');
    });
});