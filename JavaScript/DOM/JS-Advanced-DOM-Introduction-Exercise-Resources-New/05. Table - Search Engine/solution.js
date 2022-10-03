function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let rows = document.querySelectorAll('tbody tr');
      let searchStr = document.getElementById('searchField').value;
      for (let row of rows) {
         row.classList.remove('select');

         if(searchStr && row.textContent.includes(searchStr)){
            row.classList.add('select');
         }
      }
      document.getElementById('searchField').value = '';
   }
}