function findBestPrice(arr){
let bestPrice = {};
arr.forEach(element => {
  let input = element.split(' | ');
  if (bestPrice[input[1]] === undefined) {
    bestPrice[input[1]] = {town:input[0],price:Number(input[2])}
  }
  else if(bestPrice[input[1]].price > Number(input[2])){
    bestPrice[input[1]].town=input[0];
    bestPrice[input[1]].price=Number(input[2]);
  }
});

for (let product in bestPrice) {
  console.log(`${product} -> ${bestPrice[product].price} (${bestPrice[product].town})`);  
}

};

findBestPrice(['Sample Town | Sample Product | 1000',
'Sample Town | Orange | 2',
'Sample Town | Peach | 1',
'Sofia | Orange | 1',
'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10']
);

