const { assert } = require('chai');
let companyAdministration = require('../companyAdministration');

describe("Tests …", function () {
    describe("hiringEmployee …", function () {
        it("3", function () {
            //Arrange
            let expected = `Georgi was successfully hired for the position Programmer.`;
            //Act
            let actual = companyAdministration.hiringEmployee('Georgi', 'Programmer', 3)
            //Assert
            assert.equal(actual, expected);
        });
        it("5", function () {
            //Arrange
            let expected = `Georgi was successfully hired for the position Programmer.`;
            //Act
            let actual = companyAdministration.hiringEmployee('Georgi', 'Programmer', 5)
            //Assert
            assert.equal(actual, expected);
        });
        it("2", function () {
            //Arrange
            let expected = `Georgi is not approved for this position.`;
            //Act
            let actual = companyAdministration.hiringEmployee('Georgi', 'Programmer', 2)
            //Assert
            assert.equal(actual, expected);
        });
        it("0", function () {
            //Arrange
            let expected = `Georgi is not approved for this position.`;
            //Act
            let actual = companyAdministration.hiringEmployee('Georgi', 'Programmer', 0)
            //Assert
            assert.equal(actual, expected);
        });
        it("hr", function () {

            //Assert
            assert.throw(() => { companyAdministration.hiringEmployee('Georgi', 'hr', 4) }, `We are not looking for workers for this position.`)
        });
    });
    describe("calculateSalary …", function () {
        it("10", function () {
            //Arrange
            let expected = 150;
            //Act
            let actual = companyAdministration.calculateSalary(10);
            //Assert
            assert.equal(actual, expected);
        });
        it("160", function () {
            //Arrange
            let expected = 2400;
            //Act
            let actual = companyAdministration.calculateSalary(160);
            //Assert
            assert.equal(actual, expected);
        });

        it("161", function () {
            //Arrange
            let expected = 3415;
            //Act
            let actual = companyAdministration.calculateSalary(161);
            //Assert
            assert.equal(actual, expected);
        });

        it("-1", function () {

            //Assert
            assert.throw(() => { companyAdministration.calculateSalary(-1) }, "Invalid hours")
        });
        it("-10", function () {

            //Assert
            assert.throw(() => { companyAdministration.calculateSalary(-10) }, "Invalid hours")
        });
        it("[]", function () {

            //Assert
            assert.throw(() => { companyAdministration.calculateSalary([1]) }, "Invalid hours")
        });
        it("bool", function () {

            //Assert
            assert.throw(() => { companyAdministration.calculateSalary(true) }, "Invalid hours")
        });
        it("{}", function () {

            //Assert
            assert.throw(() => { companyAdministration.calculateSalary({}) }, "Invalid hours")
        });
    });
    describe("firedEmployee …", function () {
        it("i2", function () {
            //Arrange
            let expected = ['georgi', 'peter'].join(', ');
            //Act
            let actual = companyAdministration.firedEmployee(['georgi', 'peter', 'ivan'], 2)
            //Assert
            assert.equal(actual, expected);
        });
        it("i0", function () {
            //Arrange
            let expected = ""
            //Act
            let actual = companyAdministration.firedEmployee(['ivan'], 0)
            //Assert
            assert.equal(actual, expected);
        });
        
        it("-1", function () {
            //Assert
            assert.throw(() => { companyAdministration.firedEmployee(['ivan','georgi', 'peter' ], -1) }, "Invalid input")
        });
        it("1.2", function () {
            //Assert
            assert.throw(() => { companyAdministration.firedEmployee(['georgi', 'peter', 'ivan'], 1.2) }, "Invalid input")
        });
        it("12", function () {
            //Assert
            assert.throw(() => { companyAdministration.firedEmployee(['georgi', 'peter', 'ivan'], 12) }, "Invalid input")
        });
        it("'1'", function () {
            //Assert
            assert.throw(() => { companyAdministration.firedEmployee(['georgi', 'peter', 'ivan'], '1') }, "Invalid input")
        });
        it("'[]'", function () {
            //Assert
            assert.throw(() => { companyAdministration.firedEmployee(['georgi', 'peter', 'ivan'], [1]) }, "Invalid input")
        });
        it("'{}'", function () {
            //Assert
            assert.throw(() => { companyAdministration.firedEmployee(['georgi', 'peter', 'ivan'], {}) }, "Invalid input")
        });
        
        it("'bool'", function () {
            //Assert
            assert.throw(() => { companyAdministration.firedEmployee(['georgi', 'peter', 'ivan'], true) }, "Invalid input")
        });
        it("'not arr'", function () {
            //Assert
            assert.throw(() => { companyAdministration.firedEmployee('georgi peter ivan', 2) }, "Invalid input")
        });
        it("'not arr'", function () {
            //Assert
            assert.throw(() => { companyAdministration.firedEmployee(4, 1) }, "Invalid input")
        });
        it("'not arr'", function () {
            //Assert
            assert.throw(() => { companyAdministration.firedEmployee(false, 0) }, "Invalid input")
        });
    });

});
