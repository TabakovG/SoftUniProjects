function toggle() {
    let target = document.getElementById('extra');
    let buttonLabel = document.getElementsByClassName('button')[0];

    if(buttonLabel.textContent === 'More'){
        target.style.display = 'block';
        buttonLabel.textContent = 'Less';
        }
        else{
        target.style.display = 'none';
        buttonLabel.textContent = 'More';
        } 
}