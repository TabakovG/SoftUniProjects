function filterEmpl(data, criteria) {
  let list = JSON.parse(data);
  let [prop, value] = criteria.split('-');
  let result = [];
  
  for (const match of list) {
    if (match[prop] === value) {
      result.push(match);
    }
  }
  result.forEach((x,i)=>{
    console.log(`${i}. ${x.first_name} ${x.last_name} - ${x.email}`);
  })
}



filterEmpl(`[{
  "id": "1",
  "first_name": "Ardine",
  "last_name": "Bassam",
  "email": "abassam0@cnn.com",
  "gender": "Female"
}, {
  "id": "2",
  "first_name": "Kizzee",
  "last_name": "Jost",
  "email": "kjost1@forbes.com",
  "gender": "Female"
},  
{
  "id": "3",
  "first_name": "Evanne",
  "last_name": "Maldin",
  "email": "emaldin2@hostgator.com",
  "gender": "Male"
}]`,
  'all'
);