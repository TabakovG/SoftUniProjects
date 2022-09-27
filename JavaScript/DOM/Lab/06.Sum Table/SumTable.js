function sumTable() {
  let table = document.getElementsByTagName('table')[0];
  let rows = table.children[0].children;
  let sum = 0;
  for (let i = 1; i < rows.length; i++) {
    sum += Number(rows[i].children[1].textContent);
  }
  document.getElementById('sum').textContent = sum;
}