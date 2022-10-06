function create(words) {

   let destination = document.getElementById('content');

   for (const elem of words) {
      let newDiv = document.createElement('div');
      let par = document.createElement('p');
      par.textContent = elem;
      par.style.display = 'none';
      newDiv.appendChild(par);
      newDiv.addEventListener('click', function(event){
      par.style.display = '';
      })
      destination.appendChild(newDiv);
   }
}