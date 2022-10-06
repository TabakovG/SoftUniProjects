function solve() {
  let generate = document.getElementsByTagName('button')[0];
  let buy = document.getElementsByTagName('button')[1];
  let input = document.getElementsByTagName('textarea')[0];
  let messageBox = document.getElementsByTagName('textarea')[1];
  let inventory = document.getElementsByTagName('tbody')[0];

  let prodList = [];
  let totalPrice = 0;
  let decFactor = 0;

  generate.addEventListener('click', function (event) {
    let productsArray = JSON.parse(input.value);

    for (const prod of productsArray) {

      let row = document.createElement('tr');
      //Image
      let tdImg = document.createElement('td');
      let img = document.createElement('img');

      img.src = prod.img;
      tdImg.appendChild(img);
      row.appendChild(tdImg);

      //Name
      let tdName = document.createElement('td');
      let par = document.createElement('p');

      par.textContent = prod.name;
      tdName.appendChild(par);
      row.appendChild(tdName);

      //Price
      let tdPrice = document.createElement('td');
      let cost = document.createElement('p');

      cost.textContent = prod.price;
      tdPrice.appendChild(cost);
      row.appendChild(tdPrice);

      //Decor
      let tdDecor = document.createElement('td');
      let decor = document.createElement('p');

      decor.textContent = prod.decFactor;
      tdDecor.appendChild(decor);
      row.appendChild(tdDecor);

      //Mark
      let tdMark = document.createElement('td');
      let mark = document.createElement('input');

      mark.type = 'checkbox';
      tdMark.appendChild(mark);
      row.appendChild(tdMark);

      inventory.appendChild(row);
    }

    console.log(productsArray);
  })

  buy.addEventListener('click', function (e) {
    let allProducts = document.querySelectorAll('table tbody input');

    for (const pr of allProducts) {
      if (pr.checked) {
        console.log(pr.parentNode.parentNode.querySelectorAll('td p')[0]);
        prodList.push(pr.parentNode.parentNode.querySelectorAll('td p')[0].textContent);
        totalPrice += Number(pr.parentNode.parentNode.querySelectorAll('td p')[1].textContent);
        decFactor += Number(pr.parentNode.parentNode.querySelectorAll('td p')[2].textContent);
      }
    }
    messageBox.value += `Bought furniture: ${prodList.join(', ')}\n`;
    messageBox.value += `Total price: ${totalPrice.toFixed(2)}\n`;
    messageBox.value += `Average decoration factor: ${decFactor / prodList.length}`;
  })
}