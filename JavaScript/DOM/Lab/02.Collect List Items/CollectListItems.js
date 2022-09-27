function extractText() {
    let elements = document.getElementsByTagName('li');
    let target = document.getElementById('result');
    for (let i = 0; i < elements.length; i++) {
        target.textContent += elements[i].textContent + '\n';
    }
}