function juiceFactory(arr) {
    let store = {};
    let bottles = {};
    for (const input of arr) {
        let [product, quant] = input.split(' => ');
        if (!store.hasOwnProperty(product)) {
            store[product] = 0;
        }
        store[product] += Number(quant);
        if (store[product] / 1000 >= 1) {
            if (!bottles.hasOwnProperty(product)) {
                bottles[product] = 0;
            }
            bottles[product] += Number(Math.floor(store[product] / 1000));
            store[product] %= 1000;
        }
    }
    for (const prd in bottles) {
        console.log(`${prd} => ${bottles[prd]}`);
    }

}

// juiceFactory(['Orange => 2000',
// 'Peach => 1432',
// 'Banana => 450',
// 'Peach => 600',
// 'Strawberry => 549']
// );
juiceFactory(['Kiwi => 234',
    'Pear => 2345',
    'Watermelon => 3456',
    'Kiwi => 4567',
    'Pear => 5678',
    'Watermelon => 6789', 
    'Kiwi => 834',
    'Pear => 2345',
    'Watermelon => 3456',
    'Kiwi => 4567',
    'Pear => 5678',
    'Watermelon => 6789']


);