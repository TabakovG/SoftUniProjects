const { assert } = require('chai');
const isSymmetric = require('./checkSymmetry');

describe("Check for symmetry in array tests", ()=>{
    it('should return true ', ()=>{
        //arrange
        let arr = [1,2,3,4,3,2,1];
        //act
        let actual = isSymmetric(arr);
        //assert
        assert.equal(actual, true);
    });
    it('should return true - no elements', ()=>{
        //arrange
        let arr = [];
        //act
        let actual = isSymmetric(arr);
        //assert
        assert.equal(actual, true);
    });
    it('should return true - 1 element ', ()=>{
        //arrange
        let arr = [1];
        //act
        let actual = isSymmetric(arr);
        //assert
        assert.equal(actual, true);
    });
    it('should return false - non symmetric', ()=>{
        //arrange
        let arr = [1,2,3,4,3,2];
        //act
        let actual = isSymmetric(arr);
        //assert
        assert.equal(actual, false);
    });
    it('should return false - not an array ', ()=>{
        //arrange
        let arr = 1;
        //act
        let actual = isSymmetric(arr);
        //assert
        assert.equal(actual, false);
    });
    it('should return false - mixed types ', ()=>{
        //arrange
        let arr = [1,'2',3,4,3,2,1];
        //act
        let actual = isSymmetric(arr);
        //assert
        assert.equal(actual, false);
    });
})