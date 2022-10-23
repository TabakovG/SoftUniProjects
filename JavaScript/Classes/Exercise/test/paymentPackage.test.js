const { assert } = require('chai');
const { describe } = require('mocha');
let PaymentPackage = require('../paymentPackage');

describe('Tests for the payment package class', () => {
    it('should create instance correctly with 2 params', () => {
        //Arrange
        let expectedName = 'hr';
        let expectedValue = 12;
        let expectedVat = 20;
        let expectedActive = true;

        //Act

        let actual = new PaymentPackage(expectedName, expectedValue);
        //Assert
        assert.equal(actual.name, expectedName);
        assert.equal(actual._name, expectedName);
        assert.equal(actual.value, expectedValue);
        assert.equal(actual._value, expectedValue);
        assert.equal(actual.VAT, expectedVat);
        assert.equal(actual._VAT, expectedVat);
        assert.equal(actual.active, expectedActive);
        assert.equal(actual._active, expectedActive);
    });
    it('should return correct name after change', () => {
        //Arrange
        let expectedName = 'Newname';
        let expectedValue = 12;
        //Act
        let actual = new PaymentPackage('hr', expectedValue);
        actual.name = expectedName;
        //Assert
        assert.equal(actual.name, expectedName);
        assert.equal(actual._name, expectedName);

    });
    it('should not trow error on correct name', () => {
        //Act
        let actual = new PaymentPackage('hr', 22);
        //Assert
        assert.doesNotThrow(() => { actual.name = 'a' })
        assert.doesNotThrow(() => { actual.name = 'aasd' })
        assert.doesNotThrow(() => { actual.name = 'aasd as' })

    });
    it('should return correct value after change', () => {
        //Arrange
        let expectedName = 'hr';
        let expectedValue = 12;
        //Act
        let actual = new PaymentPackage(expectedName, 2);
        actual.value = expectedValue;
        //Assert
        assert.equal(actual.value, expectedValue);
        assert.equal(actual._value, expectedValue);
    });
    it('should not trow error on correct value', () => {
        //Act
        let actual = new PaymentPackage('hr', 22);
        //Assert
        assert.doesNotThrow(() => { actual.value = 0 })
        assert.doesNotThrow(() => { actual.value = 1 })
        assert.doesNotThrow(() => { actual.value = 222 })

    });
    it('should return correct VAT after change', () => {
        //Arrange
        let expectedName = 'hr';
        let expectedValue = 12;
        //Act
        let actual = new PaymentPackage(expectedName, expectedValue);
        actual.VAT = 33;
        //Assert
        assert.equal(actual.VAT, 33);
        assert.equal(actual._VAT, 33);
    });
    it('should not trow error on correct VAT', () => {
        //Act
        let actual = new PaymentPackage('hr', 22);
        //Assert
        assert.doesNotThrow(() => { actual.VAT = 0 })
        assert.doesNotThrow(() => { actual.VAT = 1 })
        assert.doesNotThrow(() => { actual.VAT = 100 })

    });
    it('should return correct status after change', () => {
        //Act
        let actual = new PaymentPackage('hr', 22);
        actual.active = false;
        //Assert
        assert.isFalse(actual.active);
        assert.isFalse(actual._active);
    });
    it('should return correct string on toString()', () => {
        //Arrange
        let expected = 'Package: New (inactive)\n' +
            '- Value (excl. VAT): 44\n' +
            '- Value (VAT 33%): 58.52';
        //Act
        let actual = new PaymentPackage('hr', 22);
        actual.active = false;
        actual.VAT = 33;
        actual.name = 'New';
        actual.value = 44;
        //Assert
        assert.equal(actual.toString(), expected);
    });
    it('should throw error if name is not a valid string ', () => {
        assert.throw(() => { new PaymentPackage(22, 22) }, 'Name must be a non-empty string', undefined, 'Number');
        assert.throw(() => { new PaymentPackage([], 22) }, 'Name must be a non-empty string', undefined, 'Array');
        assert.throw(() => { new PaymentPackage({}, 22) }, 'Name must be a non-empty string', undefined, 'Obj');
        assert.throw(() => { new PaymentPackage("", 22) }, 'Name must be a non-empty string', undefined, 'Empty');
        assert.throw(() => { new PaymentPackage(true, 22) }, 'Name must be a non-empty string', undefined, 'Bool');
        assert.throw(() => { new PaymentPackage(undefined, 22) }, 'Name must be a non-empty string', undefined, 'undefined');
        assert.throw(() => { new PaymentPackage(null, 22) }, 'Name must be a non-empty string', undefined, 'null');

    });
    it('should throw error if value is not a valid number', () => {
        assert.throw(() => { new PaymentPackage("HR", -22) }, 'Value must be a non-negative number', undefined, 'Negative');
        assert.throw(() => { new PaymentPackage("HR", -1) }, 'Value must be a non-negative number', undefined, 'Negative');
        assert.throw(() => { new PaymentPackage("HR", '1') }, 'Value must be a non-negative number', undefined, 'String');
        assert.throw(() => { new PaymentPackage("HR", []) }, 'Value must be a non-negative number', undefined, 'Array');
        assert.throw(() => { new PaymentPackage("HR", [3]) }, 'Value must be a non-negative number', undefined, 'Array num');
        assert.throw(() => { new PaymentPackage("HR", {}) }, 'Value must be a non-negative number', undefined, 'obj');
        assert.throw(() => { new PaymentPackage("HR", '') }, 'Value must be a non-negative number', undefined, 'empty str');
        assert.throw(() => { new PaymentPackage("HR", undefined) }, 'Value must be a non-negative number', undefined, 'undefined');
        assert.throw(() => { new PaymentPackage("HR", null) }, 'Value must be a non-negative number', undefined, 'null');

    });
    it('should throw error if VAT is not a valid number', () => {
        //Act
        let actual = new PaymentPackage('hr', 22);

        //Assert
        assert.throw(() => {  actual.VAT = -33;}, 'VAT must be a non-negative number', undefined, 'Negative');
        assert.throw(() => {  actual.VAT = -3.33;}, 'VAT must be a non-negative number', undefined, 'Negative');
        assert.throw(() => {  actual.VAT = '4';}, 'VAT must be a non-negative number', undefined, 'String');
        assert.throw(() => {  actual.VAT = [4];}, 'VAT must be a non-negative number', undefined, 'Array');
        assert.throw(() => {  actual.VAT = {};}, 'VAT must be a non-negative number', undefined, 'Obj');
        assert.throw(() => {  actual.VAT = '';}, 'VAT must be a non-negative number', undefined, 'empty str');
        assert.throw(() => {  actual.VAT = undefined;}, 'VAT must be a non-negative number', undefined, 'undefined');
        assert.throw(() => {  actual.VAT = null;}, 'VAT must be a non-negative number', undefined, 'null');
       
    });
    it('should throw error if Status is not a valid boolean', () => {
        //Act
        let actual = new PaymentPackage('hr', 22);

        //Assert
        assert.throw(() => {  actual.active = -1;}, 'Active status must be a boolean', undefined, 'Negative num');
        assert.throw(() => {  actual.active = 1;}, 'Active status must be a boolean', undefined, 'Num 1');
        assert.throw(() => {  actual.active = 0;}, 'Active status must be a boolean', undefined, 'Num 0');
        assert.throw(() => {  actual.active = 'true';}, 'Active status must be a boolean', undefined, 'String');
        assert.throw(() => {  actual.active = [false];}, 'Active status must be a boolean', undefined, 'Array');
        assert.throw(() => {  actual.active = {};}, 'Active status must be a boolean', undefined, 'Obj');
        assert.throw(() => {  actual.active = '';}, 'Active status must be a boolean', undefined, 'empty str');
        assert.throw(() => {  actual.active = undefined;}, 'Active status must be a boolean', undefined, 'undefined');
        assert.throw(() => {  actual.active = null;}, 'Active status must be a boolean', undefined, 'null');
       
    });
    
});