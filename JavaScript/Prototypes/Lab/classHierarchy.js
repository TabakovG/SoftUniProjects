function createFigures() {
    class Figure {
        constructor(units = 'cm') {
            this.units = units;
        }
        get area() { }
        changeUnits(unt) {
            ['m', 'cm', 'mm'].includes(unt) ? this.units = unt : null;
        }
        toString() {
            return `Figures units: ${this.units}`;
        }
        get convertedValue() { return this.units === 'cm' ? 1 : this.units === 'mm' ? 10 : 0.01; }
    }
    class Circle extends Figure {
        constructor(radius) {
            super();
            this.radius = radius;
        }
        get area() {
            return this.radius  * this.radius * Number(Math.PI);
        }
        get radius() {
            return this._radius * this.convertedValue;
        }
        set radius(value) {
            this._radius = value;
        }
        toString() {
            return super.toString() + ` Area: ${this.area} - radius: ${this.radius}`
        }
    }
    class Rectangle extends Figure {
        constructor(width, height, units) {
            super(units);
            this.width = width;
            this.height = height;
        }
        get area() {
            return this.width  * this.height;
        }
        get width() { return this._width * this.convertedValue; }
        set width(value) {
            this._width = value;
        }
        get height() { return this._height * this.convertedValue; }
        set height(value) {
            this._height = value;
        }
        toString() {
            return super.toString() + ` Area: ${this.area} - width: ${this.width}, height: ${this.height}`
        }
    }

    let c = new Circle(5);
    console.log(c.area); // 78.53981633974483
    console.log(c.toString()); // Figures units: cm Area: 78.53981633974483 - radius: 5

    let r = new Rectangle(3, 4, 'mm');
    console.log(r.area); // 1200 
    console.log(r.toString()); //Figures units: mm Area: 1200 - width: 30, height: 40

    r.changeUnits('cm');
    console.log(r.area); // 12
    console.log(r.toString()); // Figures units: cm Area: 12 - width: 3, height: 4

    c.changeUnits('mm');
    console.log(c.area); // 7853.981633974483
    console.log(c.toString()) // Figures units: mm Area: 7853.981633974483 - radius: 50

    return { Circle, Rectangle, Figure }
}
createFigures()