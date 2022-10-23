const { should, assert } = require('chai');
const sum = require('./sumNumbers.js');

describe('Test SumNumbers function', ()=> {
    it('should return result on call', ()=>{
        //arrange
        let expected = 6;
        //act
        let actual = sum([1,2,3]);
        //assert
        assert.equal(actual,expected);
    });
    it('shoult throw an error if argument is not array', ()=>{
        assert.throw(()=>sum(1));
    })
});