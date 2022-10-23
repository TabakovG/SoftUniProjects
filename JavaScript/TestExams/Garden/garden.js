class Garden {
    constructor(spaceAvailable) {
        this.spaceAvailable = spaceAvailable;
        this.plants = [];
        this.storage = [];
    }
    addPlant(plantName, spaceRequired) {
        if (typeof (plantName) !== 'string' || typeof (spaceRequired) !== 'number') {
            throw new Error('Invalid data!');
        }
        if (spaceRequired > this.spaceAvailable) {
            throw new Error("Not enough space in the garden.");
        }
        else {
            this.spaceAvailable -= spaceRequired;
            this.plants.push({
                plantName,
                spaceRequired,
                ripe: false,
                quantity: 0
            });
            return `The ${plantName} has been successfully planted in the garden.`
        }
    }
    ripenPlant(plantName, quantity) {
        if (typeof (plantName) !== 'string' || typeof (quantity) !== 'number') {
            throw new Error('Invalid data!');
        }
        if (!this.plants.some(x => x.plantName === plantName)) {
            throw new Error(`There is no ${plantName} in the garden.`);
        }
        else {
            let plant = this.plants.find(p => p.plantName === plantName);
            if (plant.ripe === true) {
                throw new Error(`The ${plantName} is already ripe.`);
            }
            if (quantity <= 0) {
                throw new Error(`The quantity cannot be zero or negative.`);
            }
            plant.ripe = true;
            plant.quantity += quantity;
            let checkQ = quantity === 1 ? ' has' : 's have';

            return `${quantity} ${plantName}${checkQ} successfully ripened.`
        }
    }
    harvestPlant(plantName) {
        if (!this.plants.some(x => x.plantName === plantName)) {
            throw new Error(`There is no ${plantName} in the garden.`);
        }
        let plant = this.plants.find(p => p.plantName === plantName);
        if (plant.ripe === false) {
            throw new Error(`The ${plantName} cannot be harvested before it is ripe.`);
        }

        this.storage.push({ plantName: plant.plantName, quantity: plant.quantity });
        this.spaceAvailable += plant.spaceRequired;
        this.plants = this.plants.filter(x => x.plantName !== plantName);

        return `The ${plantName} has been successfully harvested.`;
    }
    generateReport() {
        let result = `The garden has ${this.spaceAvailable} free space left.\n`;
        let sorted = this.plants.sort((a, b) => {
            a.plantName.localeCompare(b.plantName);
        })
        result += `Plants in the garden: ${sorted.map(p => p.plantName).join(', ')}\n`;
        if (this.storage.length === 0) {
            result += "Plants in storage: The storage is empty.";
        }
        else {
            result += `Plants in storage: ${this.storage
                .map(p => `${p.plantName} (${p.quantity})`)
                .join(', ')}`;
        }

        return result;
    }
}

const myGarden = new Garden(250)
console.log(myGarden.addPlant('apple', 20));
console.log(myGarden.addPlant('orange', 200));
console.log(myGarden.addPlant('raspberry', 10));
console.log(myGarden.ripenPlant('apple', 10));
console.log(myGarden.ripenPlant('orange', 1));
console.log(myGarden.harvestPlant('orange'));
console.log(myGarden.generateReport());
