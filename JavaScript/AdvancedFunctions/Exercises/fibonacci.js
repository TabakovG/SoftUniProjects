function getFibonator(){
  let curentNum = 0;
  let previousNum = 0;
  
  
  return ()=>{
    let result = curentNum + previousNum;
    previousNum = curentNum;
    curentNum = result;
    return result === 0 ? ++curentNum : result;
  };
}
let fib = getFibonator();
console.log(fib()); // 1
console.log(fib()); // 1
console.log(fib()); // 2
console.log(fib()); // 3
console.log(fib()); // 5
console.log(fib()); // 8
console.log(fib()); // 13
