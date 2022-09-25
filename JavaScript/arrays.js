function evenPositionElement(input){
let result = input.filter(n => input.indexOf(n)%2 ==0);
console.log(result.join(' '));
}
evenPositionElement(['20', '30', '40', '50', '60']);
evenPositionElement(['5', '10']);


function lastKNumbersSequence(n, k){
let result = [1];
for (let i = 1; i < Number(n); i++) {
  result[i] = result.slice(-Number(k)).reduce((a,b)=> a+b);
}
return result;
}
lastKNumbersSequence(6, 3);
lastKNumbersSequence(8, 2);


function sumFirstLast(arr){
  console.log(+Number(arr.shift())+Number(arr.pop()));
  return Number(arr[0])+Number(arr[arr.length -1]);
}
sumFirstLast(['20', '30', '40']);
sumFirstLast(['5', '10']);

function negativePositiveNumbers(arr){
  let result = [];
  arr.forEach(e => {
  if (e<0) {
    result.unshift(e);
  }
  else{
  result.push(e);
  }
});

console.log(result.join('\n'));
}
negativePositiveNumbers([7, -2, 8, 9]);
negativePositiveNumbers([3, -2, 0, -1]);


function smallestTwoNumbers(arr){
  let result = arr.sort((a,b)=>a-b).slice(0,2);
  console.log(result.join(' '));
}
smallestTwoNumbers([30, 15, 50, 5]);
smallestTwoNumbers([3, 0, 10, 4, 7, 3]);


function biggerHalf(arr){
  let result = arr.sort((a,b)=>a-b).slice(Math.floor(arr.length / 2));
  return result;
}

biggerHalf([4, 7, 2, 5]);
biggerHalf([3, 19, 14, 7, 2, 19, 6]);


function pieceOfPie(arr, first, second){
  let result = arr.slice(arr.indexOf(first), arr.indexOf(second)+1);
  return result;
}

pieceOfPie(['Pumpkin Pie',
'Key Lime Pie',
'Cherry Pie',
'Lemon Meringue Pie',
'Sugar Cream Pie'],
'Key Lime Pie',
'Lemon Meringue Pie'
);
pieceOfPie(['Apple Crisp',
'Mississippi Mud Pie',
'Pot Pie',
'Steak and Cheese Pie',
'Butter Chicken Pie',
'Smoked Fish Pie'],
'Pot Pie',
'Smoked Fish Pie'
);


function processOddPositions(arr){
  let result = arr
  .filter((x, index)=>index%2 === 1)
  .map(x=>x*2)
  .reverse();
  console.log(result.join(' '));
}

processOddPositions([10, 15, 20, 25]);
processOddPositions([3, 0, 10, 4, 7, 3]);

function biggestElement(matrix){
  let maxNum = Number.MIN_SAFE_INTEGER;

  for (let i = 0; i < matrix.length; i++) {
    for (let j = 0; j < matrix[0].length; j++) {
        
      if (matrix[i][j] > maxNum) {
        maxNum = matrix[i][j];
      }
    }
  }

    console.log(maxNum);
}

biggestElement([[20, 50, 10],
  [8, 33, 145]]
 );
biggestElement([[3, 5, 7, 12],
  [-1, 4, 33, 2],
  [8, 3, 0, 4]]
 );

function diagonalSums(mtx){
  let sumPrim = 0;
  let sumSec = 0;
  for (let i = 0; i < mtx.length; i++) {
    sumPrim+=mtx[i][i];
    sumSec+=mtx[i][mtx.length-1-i]
  }
  console.log(sumPrim + ' ' + sumSec);
}

diagonalSums([[20, 40],
  [10, 60]]
 );
diagonalSums([[3, 5, 17],
  [-1, 7, 14],
  [1, -8, 89]]
 );

function equalNeighbors(matrix){
  let result = 0;
  for (let i = 0; i < matrix.length; i++) {
    for (let j = 0; j < matrix[0].length-1; j++) {
        if ((matrix[i][j] === matrix[i][j+1])) {
          result++;
        }
    }
  }
  for (let i = 0; i < matrix.length-1; i++) {
    for (let j = 0; j < matrix[0].length; j++) {
        if ((matrix[i][j] === matrix[i+1][j])) {
          result++;
        }
    }
  }
  return result;
}

equalNeighbors([['2', '3', '4', '7', '0'],
['4', '0', '5', '3', '4'],
['2', '3', '5', '4', '2'],
['9', '8', '7', '5', '4']]
);
equalNeighbors([['test', 'yes', 'yo', 'ho'],
['well', 'done', 'yo', '6'],
['not', 'done', 'yet', '5']]
);

