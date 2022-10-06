function lockedProfile() {
    document.getElementById("main").addEventListener('click', function (event) {

        if (event.target.nodeName === 'BUTTON') {
            let par = event.target.parentElement;
            if (par.querySelector("input[type=radio]:checked").value === 'unlock') {
                if (event.target.textContent === 'Show more') {
                    par.querySelector('div').style.display = 'block';
                    event.target.textContent = 'Hide it';
                }
                else {
                    par.querySelector('div').style.display = 'none';
                    event.target.textContent = 'Show more';
                }
            }
        }
    })
}