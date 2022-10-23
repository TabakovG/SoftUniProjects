const { assert } = require('chai');
let bookSelection = require('../bookSelection');

describe("Tests for Book selection", function () {
    describe("Tests for isGenreSuitable module", function () {
        it("should have ownProperty isGenreSuitable", function () {
            //Assert
            assert.isTrue(bookSelection.hasOwnProperty('isGenreSuitable'));
        });
        it("should be suitable for age 13 and Comedy", function () {
            //Assert
            assert.equal(bookSelection.isGenreSuitable('Comedy', 13), `Those books are suitable`);
        });
        it("should be suitable for age 12 and Comedy", function () {
            //Assert
            assert.equal(bookSelection.isGenreSuitable('Comedy', 12), `Those books are suitable`);
        });
        it("should not be suitable for age 1 and Comedy", function () {
            //Assert
            assert.equal(bookSelection.isGenreSuitable('Comedy', 1), `Those books are suitable`);
        });
        it("should be suitable for age 13 and Horror", function () {
            //Assert
            assert.equal(bookSelection.isGenreSuitable('Horror', 13), `Those books are suitable`);
        });
        it("should be suitable for age 13 and Thriller", function () {
            //Assert
            assert.equal(bookSelection.isGenreSuitable('Thriller', 13), `Those books are suitable`);
        });
        it("should not be suitable for age 12 and Horror", function () {
            //Assert
            assert.equal(bookSelection.isGenreSuitable('Horror', 12), `Books with Horror genre are not suitable for kids at 12 age`);
        });
        it("should not be suitable for age 12 and Thriller", function () {
            //Assert
            assert.equal(bookSelection.isGenreSuitable('Thriller', 12), `Books with Thriller genre are not suitable for kids at 12 age`);
        });
        it("should not be suitable for age 2 and Thriller", function () {
            //Assert
            assert.equal(bookSelection.isGenreSuitable('Thriller', 2), `Books with Thriller genre are not suitable for kids at 2 age`);
        });
    });

    describe('Tests for isItAffordable method', () => {
        it("should have ownProperty isItAffordable", function () {
            //Assert
            assert.isTrue(bookSelection.hasOwnProperty('isItAffordable'));
        });
        it("should be able to buy a book - (2,12)", () => {
            //Assert
            assert.equal(bookSelection.isItAffordable(2, 12), `Book bought. You have 10$ left`);
        });
        it("should be able to buy a book - (12,12)", () => {
            //Assert
            assert.equal(bookSelection.isItAffordable(12, 12), `Book bought. You have 0$ left`);
        });
        it("should be able to buy a book - (0,12)", () => {
            //Assert
            assert.equal(bookSelection.isItAffordable(0, 12), `Book bought. You have 12$ left`);
        });
        it("should be able to buy a book - (12,12)", () => {
            //Assert
            assert.equal(bookSelection.isItAffordable(12, 12), `Book bought. You have 0$ left`);
        });
        it("should throw error if input is not a number - string", () => {
            //Assert
            assert.throw(() => { bookSelection.isItAffordable('10', 12) }, "Invalid input");
        });
        it("should throw error if input is not a number - string", () => {
            //Assert
            assert.throw(() => { bookSelection.isItAffordable(10, '12') }, "Invalid input");
        });
        it("should throw error if input is not a number - arr", () => {
            //Assert
            assert.throw(() => { bookSelection.isItAffordable([10], 12) }, "Invalid input");
        });
        it("should throw error if input is not a number - object", () => {
            //Assert
            assert.throw(() => { bookSelection.isItAffordable(10, {}) }, "Invalid input");
        });
        it("should throw error if input is not a number - bool", () => {
            //Assert
            assert.throw(() => { bookSelection.isItAffordable(true, 12) }, "Invalid input");
        });
        it("should return error if price is more than budget", () => {
            //Assert
            assert.equal(bookSelection.isItAffordable(10, 2), "You don't have enough money");
        });

        it("should return error if price is more than budget", () => {
            //Assert
            assert.equal(bookSelection.isItAffordable(1, 0), "You don't have enough money");
        });
    });
    describe('Tests for suitableTitles method', () => {
        it("should have ownProperty suitableTitles", function () {
            //Assert
            assert.isTrue(bookSelection.hasOwnProperty('suitableTitles'));
        });

        it("should return expected result if input is valid - 2 books", () => {
            //Arrange 
            let input = [
                { genre: 'Comedy', title: "book1" },
                { genre: 'Horror', title: "book2" },
                { genre: 'Comedy', title: "book3" },
                { genre: 'Thriller', title: "book4" }];
            let expected = ['book1', 'book3'];
            //Act
            let actual = bookSelection.suitableTitles(input, 'Comedy');
            //Assert
            assert.equal(actual.join(), expected.join());
        });

        it("should return expected result if input is valid - 1 book", () => {
            //Arrange 
            let input = [
                { genre: 'Comedy', title: "book1" },
                { genre: 'Horror', title: "book2" },
                { genre: 'Action - Comedy', title: "book3" },
                { genre: 'Thriller', title: "book4" }];
            let expected = ['book1'];
            //Act
            let actual = bookSelection.suitableTitles(input, 'Comedy');
            //Assert
            assert.equal(actual.join(), expected.join());
        });
        it("should return expected result if input is valid - 0 books", () => {
            //Arrange 
            let input = [
                { genre: 'Action - Comedy', title: "book1" },
                { genre: 'Horror', title: "book2" },
                { genre: 'Black Comedy', title: "book3" },
                { genre: 'Thriller', title: "book4" }];
            let expected = [];
            //Act
            let actual = bookSelection.suitableTitles(input, 'Comedy');
            //Assert
            assert.equal(actual.join(), expected.join());
        });

        it("should throw error if input is not an array - bool", () => {
            //Assert
            assert.throw(() => { bookSelection.suitableTitles(true, 'Comedy') }, "Invalid input");
        });
        it("should throw error if input is not an array - num", () => {
            //Assert
            assert.throw(() => { bookSelection.suitableTitles(2, 'Comedy') }, "Invalid input");
        });
        it("should throw error if input is not an array - string", () => {
            //Assert
            assert.throw(() => { bookSelection.suitableTitles('book1, book2, book3', 'Comedy') }, "Invalid input");
        });
        it("should throw error if input is not an array - obj", () => {
            //Assert
            assert.throw(() => { bookSelection.suitableTitles({}, 'Comedy') }, "Invalid input");
        });
        it("should throw error if genre is not a string - num", () => {
            //Arrange 
            let input = [
                { genre: 'Comedy', title: "book1" },
                { genre: 'Horror', title: "book2" },
                { genre: 'Comedy', title: "book3" },
                { genre: 'Thriller', title: "book4" }];
            //Assert
            assert.throw(() => { bookSelection.suitableTitles(input, 3) }, "Invalid input");
        });
        it("should throw error if genre is not a string - bool", () => {
            //Arrange 
            let input = [
                { genre: 'Comedy', title: "book1" },
                { genre: 'Horror', title: "book2" },
                { genre: 'Comedy', title: "book3" },
                { genre: 'Thriller', title: "book4" }];
            //Assert
            assert.throw(() => { bookSelection.suitableTitles(input, false) }, "Invalid input");
        });
        it("should throw error if genre is not a string - arr", () => {
            //Arrange 
            let input = [
                { genre: 'Comedy', title: "book1" },
                { genre: 'Horror', title: "book2" },
                { genre: 'Comedy', title: "book3" },
                { genre: 'Thriller', title: "book4" }];
            //Assert
            assert.throw(() => { bookSelection.suitableTitles(input, ['Comedy', 'Action']) }, "Invalid input");
        });
    });

});
