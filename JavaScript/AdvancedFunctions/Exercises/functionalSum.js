
function add(num) {
  let sum = 0;
  sum += num;
  function cal(n) {
    sum += n;
    return cal;
  }
  cal.toString = function(){return sum;}
  return cal;
}
  
console.log(add(1)(2).toString());