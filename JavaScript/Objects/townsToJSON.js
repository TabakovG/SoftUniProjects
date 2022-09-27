function townJson(arr){
  let result = [];
  
for (let i = 1; i < arr.length; i++) {

  let data = arr[i].split(/\s?\|\s?/).filter(e=>e);
  result.push({
    Town: data[0],
    Latitude: parseFloat(Number(data[1]).toFixed(2)),
    Longitude: parseFloat(Number(data[2]).toFixed(2))
  });

}

console.log(JSON.stringify(result));
}
townJson(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']
);