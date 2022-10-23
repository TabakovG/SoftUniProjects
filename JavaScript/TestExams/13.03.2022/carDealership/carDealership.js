class CarDealership {
    constructor(name) {
        this.name = name;
        this.availableCars = [];
        this.soldCars = [];
        this.totalIncome = 0;
    }

    addCar(model, horsepower, price, mileage) {
        if (model === ''
            || horsepower < 0
            || !Number.isInteger(horsepower)
            || price < 0
            || mileage < 0) {
            throw new Error("Invalid input!");
        }
        this.availableCars.push({ model, horsepower: Number(horsepower), price: Number(price), mileage: Number(mileage) });
        return `New car added: ${model} - ${horsepower} HP - ${mileage.toFixed(2)} km - ${price.toFixed(2)}$`
    }

    sellCar(model, desiredMileage) {
        let car = this.availableCars.find(x => x.model === model);
        if (car === undefined) {
            throw new Error(`${model} was not found!`)
        }
        if (car.mileage > desiredMileage) {
            if (car.mileage - desiredMileage <= 40000) {
                car.price *= 0.95;
            }
            else {
                car.price *= 0.9;
            }
        }
        let soldCar = { model, horsepower: Number(car.horsepower), soldPrice: car.price };
        this.soldCars.push(soldCar);
        this.totalIncome += car.price;
        this.availableCars = this.availableCars.filter(x => x.model !== model);
        return `${model} was sold for ${soldCar.soldPrice.toFixed(2)}$`
    }

    currentCar() {
        if (this.availableCars.length === 0) {
            return "There are no available cars";
        }
        let result = `-Available cars:\n`;
        this.availableCars.forEach(c=>{
            result += `---${c.model} - ${c.horsepower} HP - ${c.mileage.toFixed(2)} km - ${c.price.toFixed(2)}$\n`
        })
        return result.trim();
    }

    salesReport (criteria){
        if (criteria !== 'horsepower' && criteria !== 'model') {
            throw new Error(`Invalid criteria!`);
        }
        let sortCr = criteria === 'horsepower' ? (a,b)=>b.horsepower - a.horsepower : (a,b)=>a.model.localeCompare(b.model);

        let result = `-${this.name} has a total income of ${this.totalIncome.toFixed(2)}$\n`;
        result += `-${this.soldCars.length} cars sold:\n`;
        this.soldCars.sort(sortCr).forEach(car=>{
            result+=`---${car.model} - ${car.horsepower} HP - ${car.soldPrice.toFixed(2)}$\n`;
        })
        return result.trim();
    }

}

let dealership = new CarDealership('SoftAuto');
dealership.addCar('Toyota Corolla', 100, 3500, 190000);
dealership.addCar('Mercedes C63', 300, 29000, 187000);
dealership.addCar('Audi A3', 120, 4900, 240000);
dealership.sellCar('Toyota Corolla', 30000);
dealership.sellCar('Mercedes C63', 110000);
dealership.sellCar('Audi A3', 110000);
console.log(dealership.salesReport('model'));


