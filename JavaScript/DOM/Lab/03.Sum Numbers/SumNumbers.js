function calc() {
    let num1 = document.getElementById('num1').value;
    let num2 = document.getElementById('num2').value;

    let target = document.getElementById('sum');
    target.value = Number(num1) + Number(num2);
}
