function registerCars(arr){
    let result = {};
    for (const type of arr) {
        let [brand, model, quantity] = type.split(' | ');

        if (!result.hasOwnProperty(brand)) {
            result[brand]={};
        }
        if (!result[brand].hasOwnProperty([model])) {
            result[brand][model]=0;
        }
        result[brand][model]+=Number(quantity);
    }

    for (const carBrand in result) {
        console.log(carBrand);
        for (const carModel in result[carBrand]) {
            console.log(`###${carModel} -> ${result[carBrand][carModel]}`);
        }
    }

}

registerCars(['Audi | Q7 | 1000',
'Audi | Q6 | 100',
'BMW | X5 | 1000',
'BMW | X6 | 100',
'Citroen | C4 | 123',
'Volga | GAZ-24 | 1000000',
'Lada | Niva | 1000000',
'Lada | Jigula | 1000000',
'Citroen | C4 | 22',
'Citroen | C5 | 10']
);