window.addEventListener('load', solve);

function solve() {
    let product = document.getElementById('type-product');
    let description = document.getElementById('description');
    let clientName = document.getElementById('client-name');
    let clientPhone = document.getElementById('client-phone');
    let submit = document.querySelector('form button');
    let received = document.getElementById('received-orders');
    let compleated = document.getElementById('completed-orders');
    let clearBtn = document.querySelector('.clear-btn');

    submit.addEventListener('click', submitForm);

    function buildElement(type, classes, textCont, parentEl) {
        let newE = document.createElement(type);
        classes !== undefined ? newE.classList = classes : null;
        newE.textContent !== undefined ? newE.textContent = textCont : null;
        parentEl !== undefined ? parentEl.appendChild(newE) : null;
        return newE;
    }

    function submitForm(e) {
        e.preventDefault();

        if (!description.value || !clientName.value || !clientPhone.value) {
            return;
        }

        let order = buildElement('div', 'container', undefined, received);
        let h2 = buildElement('h2', undefined, 'Product type for repair: ' + product.value, order);
        let h3 = buildElement('h3', undefined, 'Client information: ' + clientName.value + ', ' + clientPhone.value, order);
        let h4 = buildElement('h4', undefined, 'Description of the problem: ' + description.value, order);
        let startButton = buildElement('button', 'start-btn', 'Start repair', order);
        let finishButton = buildElement('button', 'finish-btn', 'Finish repair', order);
        startButton.addEventListener('click', (e) => {
            startButton.setAttribute('disabled', true);
            finishButton.removeAttribute('disabled');
        });
        finishButton.addEventListener('click', (e) => {
            compleated.appendChild(order);
            startButton.remove();
            finishButton.remove();
        });
        finishButton.setAttribute('disabled', true);


        description.value = '';
        clientName.value = '';
        clientPhone.value = '';

    }

    clearBtn.addEventListener('click', (e)=>{
        Array.from(document.querySelectorAll('#completed-orders .container'))
        .forEach(x=>x.remove());
    })
}