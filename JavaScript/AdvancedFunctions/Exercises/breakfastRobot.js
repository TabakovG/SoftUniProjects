function solution() {
  let stock = {
    protein: 0,
    carbohydrate: 0,
    fat: 0,
    flavour: 0
  };
  let meals = {
    apple: {
      carbohydrate: 1,
      flavour: 2
    },
    lemonade: {
      carbohydrate: 10,
      flavour: 20
    },
    burger: {
      carbohydrate: 5,
      fat: 7,
      flavour: 3
    },
    eggs: {
      protein: 5,
      fat: 1,
      flavour: 1
    },
    turkey: {
      protein: 10,
      carbohydrate: 10,
      fat: 10,
      flavour: 10
    },
  };

  let robot = {
    restock(el, quant) { stock[el] += Number(quant); return 'Success' },
    prepare(recipe, quant) {
      for (const ingr in meals[recipe]) {
        if (meals[recipe][ingr] * quant > stock[ingr]) {
          return `Error: not enough ${ingr} in stock`;
        }
      }
      for (const ingr in meals[recipe]) {
        stock[ingr] -= meals[recipe][ingr] * quant;
      }
      return 'Success'
    },
    report() { 
      let result = [];
      for (const key in stock) {
        result.push(`${key}=${stock[key]}`)
      }
      return result.join(' ') 
    }
  }

  return function (input) {
    let [cmd, el, q] = input.split(' ');
    return robot[cmd](el, q);
  }

}
let manager = solution();
console.log(manager("restock flavour 50")); // Success 
console.log(manager("prepare lemonade 4")); // Error: not enough carbohydrate in stock 
console.log(manager("restock carbohydrate 10"));
console.log(manager("restock flavour 10"));
console.log(manager("prepare apple 1"));
console.log(manager("restock fat 10"));
console.log(manager("prepare burger 1"));
console.log(manager("report"));  
