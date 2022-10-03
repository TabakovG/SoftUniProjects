function solve() {
  let text = document.getElementById('input').value;
  let output = document.getElementById('output');

  let paragraphs = text
    .match(/(?:\s*)([^.!?]+[.!?]+)/g)
    .map(x=>x.trim())
    .filter(x => x.length > 0)
    .reduce((arr, sen, index) => {
      if (index % 3 === 0) {
        arr.push([sen]);
      }
      else {
        arr[arr.length - 1].push(sen); 
      }
      return arr;
    },[]);

    console.log(paragraphs);
    paragraphs.forEach(pg => {
      let newP = document.createElement('p');
      newP.innerText = pg.join('');
      output.appendChild(newP);
    });
}