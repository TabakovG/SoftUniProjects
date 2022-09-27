function solve() {
  let text = document.getElementById('text').value;
  let convention = document.getElementById('naming-convention').value;
  let result = '';
  let arr = text.split(' ');
  for (let i = 0; i < arr.length; i++) {
      result += arr[i][0].toUpperCase() + arr[i].substring(1).toLowerCase();
  }
  if(convention === "Camel Case"){
    result = result[0].toLowerCase() + result.substring(1);
  }
  else if(convention !== "Pascal Case"){
    result = 'Error!';
  }

  document.getElementById('result').textContent = result;
  console.log(result);

}