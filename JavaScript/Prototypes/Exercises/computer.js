function createComputerHierarchy() {
    class Hardware {
        constructor(manufacturer) {
            this.manufacturer = manufacturer;
            if (this.constructor === Hardware ) {
                throw new Error("Hardware is abstract class and can't be directly created!");
              }
        }
    }
    class Keyboard extends Hardware {
        constructor(manufacturer, responseTime) {
            super(manufacturer);
            this.responseTime = responseTime;
        }
    }
    class Monitor extends Hardware {
        constructor(manufacturer, width, height) {
            super(manufacturer);
            this.width = width;
            this.height = height;
        }
    }
    class Battery extends Hardware {
        constructor(manufacturer, expectedLife ) {
            super(manufacturer);
            this.expectedLife = expectedLife;
        }
    }
    class Computer extends Hardware {
        constructor(manufacturer, processorSpeed , ram, hardDiskSpace ) {
            super(manufacturer);
            this.processorSpeed = processorSpeed;
            this.ram = ram;
            this.hardDiskSpace = hardDiskSpace;
            if (this.constructor === Computer ) {
                throw new Error("Computer is abstract class and can't be directly created!");
              }
        }
    }
    class Laptop extends Computer{
        constructor(manufacturer, processorSpeed , ram, hardDiskSpace, weight, color, battery) {
            super(manufacturer, processorSpeed , ram, hardDiskSpace);
           this.weight = weight;
           this.color = color;
           this.battery = battery;
        }
        get battery(){return this._battery};
        set battery(value){
            if (value instanceof Battery) {
                this._battery = value;
            }
            else{
                throw new TypeError(`Provide a valid battery!`)
            }
        }
    }
    class Desktop extends Computer{
        constructor(manufacturer, processorSpeed , ram, hardDiskSpace, keyboard, monitor) {
            super(manufacturer, processorSpeed , ram, hardDiskSpace);
           this.keyboard = keyboard;
           this.monitor = monitor;
        }
        get keyboard(){return this._keyboard}
        set keyboard(value){
            if (value instanceof Keyboard) {
                this._keyboard = value;
            }
            else{
                throw new TypeError(`Provide a valid keyboard!`)
            }
        }
        get monitor(){return this._monitor}
        set monitor(value){
            if (value instanceof Monitor) {
                this._monitor = value;
            }
            else{
                throw new TypeError(`Provide a valid monitor!`)
            }
        }
    }
    
    return { Hardware, Computer, Laptop, Desktop, Monitor, Battery, Keyboard }
}

let classes = createComputerHierarchy();
let Computer = classes.Computer;
let Laptop = classes.Laptop;
let Desktop = classes.Desktop;
let Monitor = classes.Monitor;
let Battery = classes.Battery;
let Keyboard = classes.Keyboard;
let Hardware = classes.Hardware;

let battery = new Battery('Energy', 3);
console.log(battery);
let laptop = new Laptop("Hewlett Packard", 2.4, 4, 0.5, 3.12, "Silver", battery);
//let com = new Hardware("Hewlett Packard", 2.4, 4, 0.5);
//console.log(com)
console.log(laptop);
