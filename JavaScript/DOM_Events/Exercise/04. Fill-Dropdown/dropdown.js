function addItem() {
    let menu = document.getElementById('menu');
    let optionLabel = document.getElementById('newItemText');
    let optionValue = document.getElementById('newItemValue');

    let newOpt = document.createElement('option');
    newOpt.textContent = optionLabel.value;
    newOpt.value = optionValue.value;
    menu.appendChild(newOpt);

    optionLabel.value='';
    optionValue.value='';

}