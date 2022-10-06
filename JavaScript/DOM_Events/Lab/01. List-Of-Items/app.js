function addItem() {
    let destination = document.getElementById('items');
    let source = document.getElementById('newItemText');

    let element = document.createElement('li');
    element.textContent = source.value;
    destination.appendChild(element);
    source.value = '';
}