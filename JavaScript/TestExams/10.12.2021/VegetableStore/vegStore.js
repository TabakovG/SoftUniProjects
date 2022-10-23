class VegetableStore {
    constructor(owner, location) {
        this.owner = owner;
        this.location = location;
        this.availableProducts = [];
    }
    loadingVegetables(vegs) {
        let result = [];
        for (const veg of vegs) {
            let [type, quantity, price] = veg.split(' ');
            if (result.indexOf(type) === -1) {
                result.push(type);
            }

            if (!this.availableProducts.some(x => x.type === type)) {
                this.availableProducts.push({ type, quantity:Number(quantity), price:Number(price) })
            }
            else {
                let prd = this.availableProducts.find(x => x.type === type);
                prd.quantity += Number(quantity);
                if (prd.price < price) {
                    prd.price = Number(price);
                }
            }
        }

        return `Successfully added ${result.join(', ')}`;
    }
    buyingVegetables(selectedProducts) {
        let totalPrice = 0;
        for (const order of selectedProducts) {
            let [type, quant] = order.split(' ');
            if (!this.availableProducts.some(x=>x.type === type)) {
                throw new Error(`${type} is not available in the store, your current bill is $${totalPrice.toFixed(2)}.`)
            }
            let product = this.availableProducts.find(x=>x.type === type)
            if (product.quantity < quant) {
                throw new Error(`The quantity ${quant} for the vegetable ${type} is not available in the store, your current bill is $${totalPrice.toFixed(2)}.`)
            }
            product.quantity -= quant;
            totalPrice += quant * product.price;
        }
        return `Great choice! You must pay the following amount $${totalPrice.toFixed(2)}.`;
    }
    rottingVegetable (type, quant){
        if (!this.availableProducts.some(x=>x.type === type)) {
            throw new Error(`${type} is not available in the store.`)
        }
        let product = this.availableProducts.find(x=>x.type === type)
            if (product.quantity < quant) {
                product.quantity = 0;
                return `The entire quantity of the ${type} has been removed.`
            }
            else{
                product.quantity -= Number(quant);
                return `Some quantity of the ${type} has been removed.`
            }
    }
    revision (){
        let result = "Available vegetables:\n";
        for (const prd of this.availableProducts.sort((a,b) => a.price - b.price)) {
            result += `${prd.type}-${prd.quantity}-$${prd.price}\n`;
        }
        result += `The owner of the store is ${this.owner}, and the location is ${this.location}.`;

        return result;
    }
}

let vegStore = new VegetableStore("Jerrie Munro", "1463 Pette Kyosheta, Sofia");
console.log(vegStore.loadingVegetables(["Okra 2.5 3.5", "Beans 10 2.8", "Celery 5.5 2.2", "Celery 0.5 2.5"]));
console.log(vegStore.rottingVegetable("Okra", 1));
console.log(vegStore.rottingVegetable("Okra", 2.5));
console.log(vegStore.buyingVegetables(["Beans 8", "Celery 1.5"]));
console.log(vegStore.revision());

