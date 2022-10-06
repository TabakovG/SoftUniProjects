function addItem() {
    let destination = document.getElementById('items');
    let source = document.getElementById('newItemText');

    //li
    let element = document.createElement('li');
    element.textContent = source.value;

    //del link
    let dLink = document.createElement('a');
    dLink.href = '#';
    dLink.textContent = '[Delete]';
    dLink.addEventListener('click', deleteRow);

    function deleteRow(){
        destination.removeChild(element);
    }

    element.appendChild(dLink);
    destination.appendChild(element);
    source.value = '';
}