class Person{
    constructor(firstName,lastName, age, email){
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.email = email;
    }
    toString(){
        return `${this.firstName} ${this.lastName} (age: ${this.age}, email: ${this.email})` 
    }
}

let p = new Person('Georgi', 'Tabakov', 32, 'gnt@gmail.com');
console.log(p.toString());

module.exports = Person;