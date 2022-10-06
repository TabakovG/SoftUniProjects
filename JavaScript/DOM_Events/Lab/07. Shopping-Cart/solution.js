function solve() {
   let cart = document.querySelector('.shopping-cart');
   let resultBox = document.getElementsByTagName('textarea')[0];
   let list = [];
   let totalPrice = 0;
   cart.addEventListener('click', function (event) {
      if (event.target.classList[0] === 'add-product') {

         let price = event.target.parentElement.parentElement.querySelector('.product-line-price').textContent;
         let name = event.target.parentElement.parentElement.querySelector('.product-title').textContent;
         if (!list.includes(name)) {
            list.push(name);
         }
         totalPrice += Number(price);
         resultBox.textContent += `Added ${name} for ${price} to the cart.\n`
         //debugger;
      }
      else if (event.target.classList[0] === 'checkout') {
         let result = `You bought ${list.join(', ')} for ${totalPrice.toFixed(2)}.`;
         resultBox.textContent += result;

         for (const btn of document.getElementsByTagName('button')) {
            btn.setAttribute('disabled', '');
         }

      }
   })
}