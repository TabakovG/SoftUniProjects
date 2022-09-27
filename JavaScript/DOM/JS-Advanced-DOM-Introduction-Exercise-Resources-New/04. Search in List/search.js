function search() {
   let arr = document.getElementsByTagName('li');
   let phrase = document.getElementById('searchText').value;
   let count = 0;

   for (let i = 0; i < arr.length; i++) {
      arr[i].removeAttribute('style');
         
      if (arr[i].textContent.includes(phrase)) {
         arr[i].style.textDecoration = 'underline';
         arr[i].style.fontWeight = 'bold';
         count++;
      }
   }

   document.getElementById('result').textContent = `${count} matches found`;
}
