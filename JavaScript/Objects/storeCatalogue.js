function storeCatalog(arr){
  arr.sort((a,b) => a.localeCompare(b));
  let store = {};
  arr.forEach(product => {
    let data = product.split(' : ');
    let group = data[0][0];

    if(store[group] === undefined){
      store[group] = {};
    }
    store[group][data[0]] = Number(data[1]);
  });

  for (const group in store) {
    console.log(group);
    for (const product in store[group]) {
    console.log(`  ${product}: ${store[group][product]}`);
      
    }
  }
  
}
storeCatalog(['Banana : 2',
`Rubic's Cube : 5`,
'Raspberry P : 4999',
'Rolex : 100000',
'Rollon : 10',
'Rali Car : 2000000',
'Pesho : 0.000001',
'Barrel : 10']

);