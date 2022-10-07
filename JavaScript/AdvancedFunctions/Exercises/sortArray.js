function sortArray(arr, type){
  let sorter = {
    asc(arr){return arr.sort((a,b)=>a-b)},
    desc(arr){return arr.sort((a,b)=>b-a)}
  };
  return sorter[type](arr);
}

console.log(sortArray([14, 7, 17, 6, 8], 'desc'));