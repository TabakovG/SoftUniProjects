function arrayWithDelimiter(arr, delimiter){
  console.log(arr.join(delimiter));
}

arrayWithDelimiter(['One', 
'Two', 
'Three', 
'Four', 
'Five'], 
'-'
);
arrayWithDelimiter(['How about no?', 
'I',
'will', 
'not', 
'do', 
'it!'], 
'_'
);

function everyNElement(arr, n){
  return arr.filter((x,index)=>index % n === 0)
}

everyNElement(['5', '20', '31', '4', '20'], 2);
everyNElement(['1', '2','3', '4', '5'], 6);

function addRemoveElm(arr){

  let num = 1;
  let result = [];
  arr.forEach(element => {
    if (element === 'add') {
      result.push(num);
    }
    else if (element === 'remove') {
      result.pop();
    }
    num++;
  });
  if (result.length === 0) {
    console.log('Empty');
    return;
  }
  console.log(result.join('\n'));
}

addRemoveElm(['add', 'add', 'add', 'add']);
addRemoveElm(['add', 'add', 'remove', 'add', 'add']);
addRemoveElm(['remove', 'remove', 'remove', 'remove', 'remove']);

function rotateArray(arr, num){
  let optimizedNum = num % arr.length;
  
  for (let i = 0; i < optimizedNum; i++) {
    arr.unshift(arr.pop());
  }
  console.log(arr.join(' '));
}

rotateArray(['1', '2', '3', '4'], 2);
rotateArray(['Banana', 'Orange', 'Coconut', 'Apple'], 15);

function increasingSubsequence(arr){

  let result = [];
  result.push(arr[0]);

  for (let i = 1; i < arr.length; i++) {
    if (arr[i] >= result[result.length-1]) {
      result.push(arr[i]);
    }
  }

  return result;
}

increasingSubsequence([1, 3, 8, 4, 10, 12, 3, 2, 24]);
increasingSubsequence([20, 3, 2, 15, 6, 1]);

function listOfNames(arr){

  arr.sort((a,b)=>a.localeCompare(b));
  for (let i = 0; i < arr.length; i++) {
    arr[i] = (i+1) + '.' + arr[i];
  }

  console.log(arr.join('\n'));
}

listOfNames(["John", "Bob", "Christina", "Ema"]);

function sortingNumbers(arr){
  arr.sort((a,b)=>a-b);
  let res = [];

  while (arr.length > 0) {
    res.push(arr.shift());
    if (arr.length === 0) {
      break;
    }
    res.push(arr.pop());
    
  }
  return res;
}

sortingNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);

function sortBy2Criteria(arr){

  arr.sort((a,b)=>{
    if(a.length-b.length !== 0){
      return a.length-b.length;
    }
    else{
      return a.toLowerCase().localeCompare(b.toLowerCase());

    }
  })

  console.log(arr.join('\n'));
}

sortBy2Criteria(['alpha', 'beta', 'gamma']);
sortBy2Criteria(['test', 'Deny', 'omen', 'Default']);

function magicMatrices(mtx){

  //let magical = true;
  let sum = mtx[0].reduce((a,b)=>a+b, 0);
  
  for (let c = 0; c < mtx[0].length; c++) {
    let cSum = 0;
    for (let r = 0; r < mtx.length; r++) {
      if (mtx[r].reduce((a,b)=>a+b, 0) !== sum) {
        return false;
      }
        cSum+=mtx[r][c];
      }
      if (cSum !== sum) {
        return false;
      }
      else{
        cSum = 0;
      }
  }
  return true;
}

magicMatrices([[4, 5, 6],  [6, 5, 4],  [5, 5, 5]] );
magicMatrices([[1, 0, 0],  [0, 0, 1],  [0, 1, 0]] );


function name(){

  console.log();
}

name();
name();


function name(){

  console.log();
}

name();
name();


function name(){

  console.log();
}

name();
name();
