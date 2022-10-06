function solve() {

    let decimal = document.getElementById('input');
    let convertOption = document.getElementById('selectMenuTo');
    let resultBox = document.getElementById('result');

    let newOptionBin = document.createElement('option');
    newOptionBin.value = 'binary';
    newOptionBin.textContent = 'Binary';
    convertOption.appendChild(newOptionBin);    
    
    let newOptionHex = document.createElement('option');
    newOptionHex.value = 'hexadecimal';
    newOptionHex.textContent = 'Hexadecimal';
    convertOption.appendChild(newOptionHex);
    
    document.querySelector('button').addEventListener('click', onClick);
    
    function onClick() {
        let number = decimal.value;

        console.log(convertOption.value);

        if (convertOption.value === 'binary') {
            let binary = "";
            while (number > 0) {
                if (number % 2 == 1) {
                    binary = "1" + binary;
                } else {
                    binary = "0" + binary;
                }
                number = Math.floor(number / 2);
            }
            console.log(binary);
            resultBox.value = binary;
        }
        else if(convertOption.value === 'hexadecimal'){
            resultBox.value = Math.abs(number).toString(16).toUpperCase();
            console.log(Math.abs(number).toString(16).toUpperCase());

        }
    }
}