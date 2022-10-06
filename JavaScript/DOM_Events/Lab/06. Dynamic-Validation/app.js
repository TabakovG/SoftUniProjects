function validate() {
    let inp = document.getElementById('email');
    inp.addEventListener('change', validateEmail);

    function validateEmail(){
        if (inp.value.match(/[a-z]+\@[a-z]+\.[a-z]+/g)) {
            inp.removeAttribute('class');
        }
        else{
            inp.classList.add('error');

        } 
    }

    console.log(inp.value.match(/[a-z]+\@[a-z]+\.[a-z]+/g));
}