function personAndTeacher() {
    class Person {
        constructor(name, email) {
            this.name = name;
            this.email = email;
        }
        toString() {
            return `${this.constructor.name} (name: ${this.name}, email: ${this.email})`
        }

    }
    class Teacher extends Person {
        constructor(name, email, subject) {
            super(name, email);
            this.subject = subject;
        }
        toString() {
            let base = Person.prototype.toString.call(this)
            return base.substring(0, base.length - 1) + `, subject: ${this.subject})`;
        }
    }
    class Student extends Person {
        constructor(name, email, course) {
            super(name, email)
            this.course = course;
        }
        toString() {
            let base = Person.prototype.toString.call(this)
            return base.substring(0, base.length - 1) + `, course: ${this.course})`;
        }

    }
    let t = new Teacher("Ivan",'ivan@ivan.com',"Graphics");
    console.log(t.toString());
    return {
        Person,
        Teacher,
        Student
    }
}

personAndTeacher();
