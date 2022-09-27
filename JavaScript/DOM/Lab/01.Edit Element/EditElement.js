function editElement(reference, strToMatch, replacement) {

    while(reference.innerText.includes(strToMatch)){
        reference.innerText = reference.innerText.replace(strToMatch, replacement);
    }
}