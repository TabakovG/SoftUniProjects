function focused() {
    let inputs = document.getElementsByTagName('input');
    for (const inp of inputs) {
        inp.addEventListener('focus', focusMe);
        inp.addEventListener('blur', blurrMe);
    }

    function focusMe(event){
        console.log('gg');
        event.target.parentElement.classList.add('focused'); 
    }
    function blurrMe(e){
        console.log('aa');
        e.target.parentElement.classList.remove('focused');
    }
}