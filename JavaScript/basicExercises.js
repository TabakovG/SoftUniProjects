function echo(inputStr){
  console.log(inputStr.length);
  console.log(inputStr);
}
echo('Hello, JavaScript!');

function strLength(ar1, ar2, ar3){
let lengthFirst = ar1.length;
let lengthSec = ar2.length;
let lengthThr = ar3.length;
let result = lengthFirst + lengthSec + lengthThr;

console.log(result);
console.log(Math.floor(result / 3));
};
strLength('chocolate', 'ice cream', 'cake');

function largestNum(...param){
console.log(Math.max(...param));
};
largestNum(5, -3, 16);

function largestN(first, second, third){
  let largest = Math.max(first,second,third);
  console.log(`The largest number is ${largest}.`);
  };
  largestN(5, -3, 16);

  function circleArea(argument)
  {
    if (typeof (argument) === 'number') {
      console.log((Math.PI*Math.pow(argument,2)).toFixed(2));
    }
    else{
      console.log(`We can not calculate the circle area, because we receive a ${typeof(argument)}.`);
    }
  }
  circleArea(5);
  circleArea('name');

  function MathOps(n1,n2,operation){
    let result;
    switch (operation) {
      case '+': result = n1+n2; break;
      case '-': result = n1-n2; break;
      case '*': result = n1*n2; break;
      case '/': result = n1/n2; break;
      case '%': result = n1%n2; break;
      case '**': result = n1**n2; break;
    }

    console.log(result);
  }
  MathOps(5, 6, '**');

  function SumNums(n1,n2){

    let result=0;
    for (let index = Number(n1); index <= Number(n2); index++) {
      result += index;
    }
    console.log(result);
  }
  SumNums('-8', '20' );

  function DayOfTheWeek(inputStr){
    let arr = ['monday', 'tuesday','wednesday','thursday','friday','saturday','sunday'];
    if (arr.includes(inputStr.toLowerCase())) {
      console.log(arr.indexOf(inputStr.toLowerCase())+1);
    }
    else{
      console.log('error');
    }
  }
  DayOfTheWeek('Monduay')

  function DayInMonth(month, year){
    let newDate = new Date(year,month,1);
    newDate.setDate(newDate.getDate() - 1);

    console.log(newDate.getDate());
  }
  DayInMonth(2, 2021);

  function SquareOfStars(num){
    let n = 5;
    if (typeof(num) === 'number' && num >= 0) {
     n = num;
    }
    let line = '* '.repeat(n);
    for (let index = 0; index < n; index++) {
      console.log(line.trim()); 
    }
  }

  SquareOfStars(-1);
  SquareOfStars(0);
  SquareOfStars();
  SquareOfStars(12);

  function AggregateElements(params){
    let resultSum = 0;
    let resultInverse = 0;
    let resultConcat = '';

    params.forEach(element => {
      resultSum+=element;
      resultInverse += 1/element;
      resultConcat += element;
    });

    console.log(resultSum);
    console.log(resultInverse);
    console.log(resultConcat);
  }
  AggregateElements([1, 2, 3])