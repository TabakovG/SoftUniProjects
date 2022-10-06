function solve(arr) {

  let buffer = [];
  for (let e of arr) {
    if (typeof e === 'number') {
      buffer.push(e);
    }
    else {
      if (buffer.length < 2) {
        return console.log('Error: not enough operands!');
      }
      let secOprd = buffer.pop();
      let firstOprd = buffer.pop();
      switch (e) {
        case '+': buffer.push(firstOprd + secOprd); break;
        case '-': buffer.push(firstOprd - secOprd); break;
        case '*': buffer.push(firstOprd * secOprd); break;
        case '/': buffer.push(firstOprd / secOprd); break;
      }
    }
  }
  if (buffer.length === 1) {
    console.log(buffer[0]);
  }
  else {
    return console.log('Error: too many operands!');
  }
}

solve([5,
  3,
  4,
  '*',
  '-']
);
solve([3,
  4,
  '/']
);
solve([15,
  '/']
);
solve([7,
  33,
  8,
  '-']
 );