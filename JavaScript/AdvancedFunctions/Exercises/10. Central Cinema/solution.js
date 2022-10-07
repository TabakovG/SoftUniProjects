function solve() {
    let inputs = document.querySelectorAll('#container input');
    let onScr = document.querySelector('#container button');
    let movies = document.querySelector('#movies ul');
    let archive = document.querySelector('#archive ul');
    clearButton = document.querySelector('#archive button');

    onScr.addEventListener('click', e => {
        e.preventDefault();
        for (let i = 0; i < inputs.length; i++) {
            //debugger
            if (inputs[i].value === "") {
                return;
            }
        }
        if (isNaN(inputs[2].value)) {
            return;
        }
        let [name, hall, price] = inputs;
        addMovie(name.value, hall.value, Number(price.value));
        for (const data of inputs) {
            data.value = '';
        }
    })

    clearButton.addEventListener('click', ()=>{
        let par = archive.parentElement;
        archive.remove();
        par.appendChild(createElement('ul'));
    })

    function addMovie(name, hall, price) {

        let li = createElement("li");
        let span = createElement('span', name);
        let strong = createElement('strong', `Hall: ${hall}`);
        let div = createElement('div');
            let strongInner = createElement('strong', price.toFixed(2));
            let inp = createElement('input', '', "Tickets Sold");
            let button = createElement('button', 'Archive');

        div.appendChild(strongInner);
        div.appendChild(inp);
        div.appendChild(button);

        li.appendChild(span);
        li.appendChild(strong);
        li.appendChild(div);

        button.addEventListener('click', e => {
            if (inp.value === '' || isNaN(Number(inp.value))) {
                return;
            }
            let total = Number(inp.value) * Number(price);
            strong.textContent = `Total amount: ${total.toFixed(2)}`;
            div.remove();
            let deleteB = createElement('button','Delete');
            deleteB.addEventListener('click', ()=>li.remove())
            li.appendChild(deleteB);
            archive.appendChild(li);
        })
        movies.appendChild(li);
    }

    function createElement(type, textContent, placeHolder) {
        let result = document.createElement(type);
        result.textContent = textContent;
        result.placeholder = placeHolder;
        return result;
    }
}