function solve() {
    let recipient = document.getElementById('recipientName');
    let title = document.getElementById('title');
    let message = document.getElementById('message');
    let btnAdd = document.getElementById('add');
    let btnReset = document.getElementById('reset');
    let list = document.querySelector('.list-mails ul');
    let sent = document.getElementsByClassName('sent-list')[0];
    let deleted = document.getElementsByClassName('delete-list')[0];

    btnAdd.addEventListener('click', (e) => {
        e.preventDefault();
        addMail();
    });
    btnReset.addEventListener('click', (e) => {
        e.preventDefault();
        resetForm();
    });

    function resetForm(){
        recipient.value = '';
        title.value = '';
        message.value = '';
    }

    function addMail() {
        if (!recipient.value || !title.value || !message.value) {
            return;
        }
        

        createMail();
        resetForm();
    }

    function createMail() {
        let li = buildElement('li', undefined, undefined, list);
        let mTitle = buildElement('h4',undefined, `Title: ${title.value}`, li)
        let mRecipient = buildElement('h4',undefined, `Recipient Name: ${recipient.value}`, li);
        let span = buildElement('span', undefined, message.value, li);
        let div = buildElement('div', ['id, list-action'],undefined,li);
        let btnSend = buildElement('button', ['type, submit','id, send'], 'Send', div);
        let btnDel = buildElement('button', ['type, submit','id, delete'], 'Delete', div);

        btnSend.addEventListener('click', () => {
            sendMail(li, mTitle, mRecipient);
        });
        btnDel.addEventListener('click', () => {
            deleteMail(li, mRecipient, mTitle);
        });
    }

    function sendMail(domEl, mTitle, mRecipient) {
        let li = buildElement('li', undefined, undefined, sent);
        let span1 = buildElement('span',undefined, `To: ${mRecipient.textContent.split(': ')[1]}`, li);
        let span2 = buildElement('span',undefined, mTitle.textContent, li);
        let div = buildElement('div', ['class, btn'], undefined, li);
        let btnDel = buildElement('button', ['type, submit', 'class, delete'], 'Delete', div);
        btnDel.addEventListener('click', () => {
            deleteMail(li, mRecipient, mTitle);
        });
        domEl.remove();
    }

    function deleteMail(domEl, mRecipient, mTitle) {
        let li = buildElement('li', undefined, undefined, deleted);
        let span1 = buildElement('span',undefined, `To: ${mRecipient.textContent.split(': ')[1]}`, li);
        let span2 = buildElement('span',undefined, mTitle.textContent, li);
        domEl.remove();
    }

    function buildElement(type, attrArr, textCont, parentDomElement) {
        let newDomElement = document.createElement(type);
        //provide array in format ['attribute, value', 'attr2 , val2'...]
        console.log(attrArr);
        console.log(typeof (attrArr));
        if (attrArr !== undefined) {
            attrArr.forEach(element => {
                let [attribute, value] = element.split(', ');
                newDomElement.setAttribute(attribute, value);
            });
        }
        newDomElement.textContent !== undefined ? newDomElement.textContent = textCont : null;
        parentDomElement !== undefined ? parentDomElement.appendChild(newDomElement) : null;
        return newDomElement;
    }
}
solve()