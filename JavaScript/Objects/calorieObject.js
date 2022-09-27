function calObj(arr){
  let obj = {};
  
  for (let i = 0; i < arr.length; i+=2) {
    obj[arr[i]] = Number(arr[i+1]);
  }
  return obj;

}

console.log(calObj(['Potato', '93', 'Skyr', '63', 'Cucumber', '18', 'Milk', '42']));