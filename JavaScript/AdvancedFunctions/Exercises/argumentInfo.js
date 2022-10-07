function argInfo(...params){
  let data = {};
  
  for (const arg of params) {
    if (data[typeof arg] === undefined) {
      data[typeof arg] = 0;
    }
    data[typeof arg]++;
    console.log(`${typeof arg}: ${arg}`)
  }

  let sortable = [];

  for (const dataType in data) {
    sortable.push([dataType, data[dataType]]);
  }
  sortable = sortable.sort((a,b)=>b[1]-a[1]);
  for (const el of sortable) {
    console.log(`${el[0]} = ${el[1]}`);
  }
}
argInfo('cat', 42, function () { console.log('Hello world!'); });
argInfo({ name: 'bob'}, 3.333, 9.999);