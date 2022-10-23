window.addEventListener("load", solve);

function solve() {
  let make = document.getElementById('make');
  let model = document.getElementById('model');
  let year = document.getElementById('year');
  let fuel = document.getElementById('fuel');
  let originalCost = document.getElementById('original-cost');
  let sellingPrice = document.getElementById('selling-price');
  let publishBtn = document.getElementById('publish');
  let destination = document.getElementById('table-body');
  let list = document.getElementById('cars-list');
  let profit = document.getElementById('profit');
  let sum = 0;


  function buildElement(type, classes, textCont, parentEl) {
    let newE = document.createElement(type);
    classes !== undefined ? newE.classList = classes : null;
    newE.textContent !== undefined ? newE.textContent = textCont : null;
    parentEl !== undefined ? parentEl.appendChild(newE) : null;
    return newE;
  }

  publishBtn.addEventListener('click', (e) => {
    e.preventDefault();
    publishEntry();
  })

  function publishEntry() {
    if (make.value === '' || model.value === '' || year.value === ''
      || fuel.value === '' || originalCost.value === '' || sellingPrice.value === ''
      || originalCost.value > sellingPrice.value) { // or >=
      return;
    }

    let post = buildElement('tr', 'row');
    let mk = buildElement('td', undefined, make.value, post);
    let md = buildElement('td', undefined, model.value, post);
    let yr = buildElement('td', undefined, year.value, post);
    let fu = buildElement('td', undefined, fuel.value, post);
    let oc = buildElement('td', undefined, originalCost.value, post);
    let sp = buildElement('td', undefined, sellingPrice.value, post);
    let btnBox = buildElement('td', undefined, undefined, post);
    let edit = buildElement('button', 'action-btn edit', 'Edit', btnBox);
    let sell = buildElement('button', 'action-btn sell', 'Sell', btnBox);

    edit.addEventListener('click', (e) => {
      make.value = mk.textContent;
      model.value = md.textContent;
      year.value = yr.textContent;
      fuel.value = fu.textContent;
      originalCost.value = oc.textContent;
      sellingPrice.value = sp.textContent;
      post.remove();
    });
    sell.addEventListener('click', (e)=>{
      let prof = Number(sp.textContent) - Number(oc.textContent);
      let li = buildElement('li', 'each-list',undefined,list);
      let sp1 = buildElement('span', undefined, `${mk.textContent} ${md.textContent}`,li);
      let sp2 = buildElement('span', undefined, `${yr.textContent}`,li);
      let sp3 = buildElement('span', undefined, `${prof}`,li);
      post.remove();
      sum += prof;
      profit.textContent = sum.toFixed(2);
    });

    destination.appendChild(post);

    make.value = '';
    model.value = '';
    year.value = '';
    fuel.value = '';
    originalCost.value = '';
    sellingPrice.value = '';

  }

}
