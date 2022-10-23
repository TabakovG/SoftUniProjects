const { assert } = require('chai');
const { describe } = require('mocha');
let StringBuilder = require('../stringBuilder');

describe('StringBuilder class tests', () => {
    it('General Test - should return correct result with correct input', () => {
        //Arrange
        let expected = 'User,w hello, there';
        //Act
        let str = new StringBuilder('hello');
        str.append(', there');
        str.prepend('User, ');
        str.insertAt('woop', 5);
        str.remove(6, 3);
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('_stringArray Should return correct result with string input', () => {
        //Arrange
        let expected = Array.from('User');
        //Act
        let str = new StringBuilder('User');
        let actual = str._stringArray;
        //Assert
        assert.equal(typeof (str), 'object');
        assert.equal(actual.join(''), expected.join(''));
    });

    it('_stringArray Should return correct result with string input - single char', () => {
        //Arrange
        let expected = Array.from('u');
        //Act
        let str = new StringBuilder('u');
        let actual = str._stringArray;
        //Assert
        assert.equal(actual.join(''), expected.join(''));
    });

    it('_stringArray Should return correct result with string input - empty', () => {
        //Arrange
        let expected = Array.from('');
        //Act
        let str = new StringBuilder('');
        let actual = str._stringArray;
        //Assert
        assert.equal(actual.join(''), expected.join(''));
    });
    it('_stringArray Should return correct result with string input - undefined', () => {
        //Arrange
        let expected = Array.from('');
        //Act
        let str = new StringBuilder();
        let actual = str._stringArray;
        //Assert
        assert.equal(actual.join(''), expected.join(''));
    });
    it('_stringArray Should return correct result with string input - space', () => {
        //Arrange
        let expected = Array.from(' ');
        //Act
        let str = new StringBuilder(' ');
        let actual = str._stringArray;
        //Assert
        assert.equal(actual.join(''), expected.join(''));
    });
    it('append() Should return correct result with string input ', () => {
        //Arrange
        let expected = 'hello, there';
        //Act
        let str = new StringBuilder('hello');
        str.append(', there');
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('append() Should return correct result with multiple string input ', () => {
        //Arrange
        let expected = 'hello, there more';
        //Act
        let str = new StringBuilder('hello');
        str.append(', there');
        str.append(' more');
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('append() Should return correct result with string input - char ', () => {
        //Arrange
        let expected = 'helloe';
        //Act
        let str = new StringBuilder('hello');
        str.append('e');
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('append() Should return correct result with string input - space', () => {
        //Arrange
        let expected = 'hello ';
        //Act
        let str = new StringBuilder('hello');
        str.append(' ');
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('append() Should return correct result with string input - empty', () => {
        //Arrange
        let expected = 'hello';
        //Act
        let str = new StringBuilder('hello');
        str.append('');
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('prepend() Should return correct result with string input - ', () => {
        //Arrange
        let expected = 'say hello';
        //Act
        let str = new StringBuilder('hello');
        str.prepend('say ');
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('prepend() Should return correct result with string input - multiple', () => {
        //Arrange
        let expected = 'Let say hello';
        //Act
        let str = new StringBuilder('hello');
        str.prepend('say ');
        str.prepend('Let ');
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('prepend() Should return correct result with string input - char', () => {
        //Arrange
        let expected = 'shello';
        //Act
        let str = new StringBuilder('hello');
        str.prepend('s');
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('prepend() Should return correct result with string input - space', () => {
        //Arrange
        let expected = ' hello';
        //Act
        let str = new StringBuilder('hello');
        str.prepend(' ');
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('prepend() Should return correct result with string input - empty', () => {
        //Arrange
        let expected = 'hello';
        //Act
        let str = new StringBuilder('hello');
        str.prepend('');
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('insertAt() Should return correct result  - string , 0', () => {
        //Arrange
        let expected = 'say hello';
        //Act
        let str = new StringBuilder('hello');
        str.insertAt('say ', 0);
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('insertAt() Should return correct result  - string , lastIndex', () => {
        //Arrange
        let expected = 'hello there';
        //Act
        let str = new StringBuilder('hello');
        str.insertAt(' there', 5);
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('insertAt() Should return correct result  - string , middle', () => {
        //Arrange
        let expected = 'help alo';
        //Act
        let str = new StringBuilder('hello');
        str.insertAt('p a', 3);
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('insertAt() Should return correct result  - emptystring , 0', () => {
        //Arrange
        let expected = 'hello';
        //Act
        let str = new StringBuilder('hello');
        str.insertAt('', 0);
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('insertAt() Should return correct result  - char , 2', () => {
        //Arrange
        let expected = 'hevllo';
        //Act
        let str = new StringBuilder('hello');
        str.insertAt('v', 2);
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('insertAt() Should return correct result  - char , -2', () => {
        //Arrange
        let expected = 'helvlo';
        //Act
        let str = new StringBuilder('hello');
        str.insertAt('v', -2);
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    
    it('insertAt() Should return correct result  - str , -2', () => {
        //Arrange
        let expected = 'helvaslo';
        //Act
        let str = new StringBuilder('hello');
        str.insertAt('vas', -2);
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('remove() Should return correct result  - 0 , 2', () => {
        //Arrange
        let expected = 'llo';
        //Act
        let str = new StringBuilder('hello');
        str.remove(0, 2);
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('remove() Should return correct result  - 2 , 2', () => {
        //Arrange
        let expected = 'heo';
        //Act
        let str = new StringBuilder('hello');
        str.remove(2, 2);
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('remove() Should return correct result  - 3 , 2', () => {
        //Arrange
        let expected = 'hel';
        //Act
        let str = new StringBuilder('hello');
        str.remove(3, 2);
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('remove() Should return correct result  - 4 , 3', () => {
        //Arrange
        let expected = 'hell';
        //Act
        let str = new StringBuilder('hello');
        str.remove(4, 3);
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('remove() Should return correct result  - 7 , 3', () => {
        //Arrange
        let expected = 'hello';
        //Act
        let str = new StringBuilder('hello');
        str.remove(7, 3);
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('remove() Should return correct result  - 2 , 0', () => {
        //Arrange
        let expected = 'hello';
        //Act
        let str = new StringBuilder('hello');
        str.remove(2, 0);
        let actual = str.toString();

        //Assert
        assert.equal(actual, expected);
    });
    it('_vrfyParam(param) Should not throw an error if string', () => {
        //Assert
        assert.doesNotThrow(() => { StringBuilder._vrfyParam('hello'); });
    });
    it('_vrfyParam(param) Should not throw an error if string', () => {
        //Assert
        assert.doesNotThrow(() => { StringBuilder._vrfyParam('h'); });
    });
    it('_vrfyParam(param) Should not throw an error if string', () => {
        //Assert
        assert.doesNotThrow(() => { StringBuilder._vrfyParam('1'); });
    });
    it('_vrfyParam(param) Should not throw an error if string', () => {
        //Assert
        assert.doesNotThrow(() => { StringBuilder._vrfyParam(''); });
    });
    it('Should throw an error if param is not a string', () => {
        //Assert
        assert.throw(() => { new StringBuilder(1) }, 'Argument must be a string');
        assert.throw(() => { new StringBuilder([]) }, 'Argument must be a string');
        assert.throw(() => { new StringBuilder(['asd']) }, 'Argument must be a string');
        assert.throw(() => { new StringBuilder({}) }, 'Argument must be a string');
        assert.throw(() => { new StringBuilder(true) }, 'Argument must be a string');
    });

    it('Append Should throw an error if param is not a string', () => {
        //Arrange
        let strB = new StringBuilder('hello');
        //Assert
        assert.throw(() => { strB.append(1) }, 'Argument must be a string');
        assert.throw(() => { strB.append([]) }, 'Argument must be a string');
        assert.throw(() => { strB.append(['asd']) }, 'Argument must be a string');
        assert.throw(() => { strB.append({}) }, 'Argument must be a string');
        assert.throw(() => { strB.append(false) }, 'Argument must be a string');
    });
    it('Prepend Should throw an error if param is not a string', () => {
        //Arrange
        let strB = new StringBuilder('hello');
        //Assert
        assert.throw(() => { strB.prepend(1) }, 'Argument must be a string');
        assert.throw(() => { strB.prepend([]) }, 'Argument must be a string');
        assert.throw(() => { strB.prepend(['asd']) }, 'Argument must be a string');
        assert.throw(() => { strB.prepend({}) }, 'Argument must be a string');
        assert.throw(() => { strB.prepend(false) }, 'Argument must be a string');
    });
    it('InsertAt Should throw an error if param is not a string', () => {
        //Arrange
        let strB = new StringBuilder('hello');
        //Assert
        assert.throw(() => { strB.insertAt(1, 0) }, 'Argument must be a string');
        assert.throw(() => { strB.insertAt([], 0) }, 'Argument must be a string');
        assert.throw(() => { strB.insertAt(['asd'], 0) }, 'Argument must be a string');
        assert.throw(() => { strB.insertAt({}, 0) }, 'Argument must be a string');
        assert.throw(() => { strB.insertAt(false, 0) }, 'Argument must be a string');
    });

});