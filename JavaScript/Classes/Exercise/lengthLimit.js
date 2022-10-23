class Stringer {
    constructor(text, length) {
        this.innerString = text;
        this.innerLength = length;
    }
    increase(n){this.innerLength += n;}
    decrease(n){this.innerLength = this.innerLength - n > 0 ? this.innerLength - n : 0}
    toString(){
        return this.innerString.substring(0,this.innerLength) 
        + (this.innerLength >= this.innerString.length ? '' : '...')}
}

let test = new Stringer("Test", 5);
console.log(test.toString()); // Test

test.decrease(3);
console.log(test.toString()); // Te...

test.decrease(5);
console.log(test.toString()); // ...

test.increase(4);
console.log(test.toString()); // Test
