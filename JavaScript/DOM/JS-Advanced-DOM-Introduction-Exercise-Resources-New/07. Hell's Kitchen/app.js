function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);
   let input = document.getElementsByTagName('textarea')[0].value;
   let bestRest = document.getElementById('bestRestaurant');
   let bestWorkers = document.getElementById('workers');

   function onClick() {
      let arr = [];
      arr = input;
      console.log(arr);

   }
}