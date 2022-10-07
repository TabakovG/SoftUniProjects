function solve() {

    let openSection = document.querySelectorAll('section div')[3];
    let progressSection = document.querySelectorAll('section div')[5];
    let finishSection = document.querySelectorAll('section div')[7];

    let input = Array.from(document.querySelectorAll('form input,textarea'));
    document.getElementById('add').addEventListener('click', e => {
        e.preventDefault();
        
        
        for (const prop of input) {
            if (prop.value.length === 0) {
                return;
            }
        }
        let art = document.createElement('article');
        let h3 = document.createElement('h3');
        let p1 = document.createElement('p');
        let p2 = document.createElement('p');
        let div = document.createElement('div');
            let b1 = document.createElement('button');
            let b2 = document.createElement('button');

        h3.textContent = input[0].value;
        p1.textContent = 'Description: ' + input[1].value;
        p2.textContent = 'Due Date: ' + input[2].value;
        div.classList += 'flex';

        b1.classList += 'green';
        b1.textContent = 'Start';
        b1.addEventListener('click', (e) => {
            b1.remove();
            let b3 = document.createElement('button');
            b3.classList = 'orange';
            b3.textContent = 'Finish';
            b3.addEventListener('click', (e) => {
                div.remove();
                finishSection.appendChild(art);
            });
            div.appendChild(b3);
            progressSection.appendChild(art);
        })

        b2.classList += 'red';
        b2.textContent = 'Delete';
        b2.addEventListener('click', (e) => {
            art.remove();
        });

        div.appendChild(b1);
        div.appendChild(b2);
        art.appendChild(h3);
        art.appendChild(p1);
        art.appendChild(p2);
        art.appendChild(div);

        openSection.appendChild(art);
    
    })
}