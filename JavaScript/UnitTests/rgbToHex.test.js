const { assert } = require('chai');
const rgbToHexColor = require('./rgbToHex');

describe('test rgb to hex converter func', () => {
    it('should convert successfully - correct inputs', () => {
        //arrange
        let [r, g, b] = [11, 22, 33];
        //act
        let actual = rgbToHexColor(r, g, b);
        //assert
        assert.equal(actual, '#0B1621');
    });
    it('should convert successfully - correct inputs 0', () => {
        //arrange
        let [r, g, b] = [0, 0, 0];
        //act
        let actual = rgbToHexColor(r, g, b);
        //assert
        assert.equal(actual, '#000000');
    });
    it('should convert successfully - correct inputs 255', () => {
        //arrange
        let [r, g, b] = [255, 255, 255];
        //act
        let actual = rgbToHexColor(r, g, b);
        //assert
        assert.equal(actual, '#FFFFFF');
    });
    it('should return undefined on num not an integer-float', () => {
        //arrange
        let [r, g, b] = [255.3, 255, 255];
        //act
        let actual = rgbToHexColor(r, g, b);
        //assert
        assert.equal(actual, undefined);
    });
    it('should return undefined on num not an integer - bool', () => {
        //arrange
        let [r, g, b] = [true, 255, 255];
        //act
        let actual = rgbToHexColor(r, g, b);
        //assert
        assert.equal(actual, undefined);
    });
    it('should return undefined on num not an integer - str num', () => {
        //arrange
        let [r, g, b] = ['12', 255, 255];
        //act
        let actual = rgbToHexColor(r, g, b);
        //assert
        assert.equal(actual, undefined);
    });
    it('should return undefined on negative red', () => {
        //arrange
        let [r, g, b] = [-1, 255, 255];
        //act
        let actual = rgbToHexColor(r, g, b);
        //assert
        assert.equal(actual, undefined);
    });
    it('should return undefined on red over 255', () => {
        //arrange
        let [r, g, b] = [256, 255, 255];
        //act
        let actual = rgbToHexColor(r, g, b);
        //assert
        assert.equal(actual, undefined);
    });
    it('should return undefined on negative green', () => {
        //arrange
        let [r, g, b] = [23, -255, 255];
        //act
        let actual = rgbToHexColor(r, g, b);
        //assert
        assert.equal(actual, undefined);
    });
    it('should return undefined on green over 255', () => {
        //arrange
        let [r, g, b] = [253, 256, 255];
        //act
        let actual = rgbToHexColor(r, g, b);
        //assert
        assert.equal(actual, undefined);
    });
    it('should return undefined on negative blue', () => {
        //arrange
        let [r, g, b] = [44, 255, -18];
        //act
        let actual = rgbToHexColor(r, g, b);
        //assert
        assert.equal(actual, undefined);
    });
    it('should return undefined on blue over 255', () => {
        //arrange
        let [r, g, b] = [256, 255, 300];
        //act
        let actual = rgbToHexColor(r, g, b);
        //assert
        assert.equal(actual, undefined);
    });
});