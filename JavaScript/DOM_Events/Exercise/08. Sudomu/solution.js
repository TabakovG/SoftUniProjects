function solve() {
    let rows = document.querySelectorAll('tbody tr');
    let check = document.getElementsByTagName('button')[0];
    let clear = document.getElementsByTagName('button')[1];
    let solved = true;
    let table = document.getElementsByTagName('table')[0];
    let result = document.getElementById('check');

    check.addEventListener('click', function (event) {
        // better cast to matrix next time !!!  
        let sum = Number(rows[0].querySelectorAll('td input')[0].value) + Number(rows[0].querySelectorAll('td input')[1].value) + Number(rows[0].querySelectorAll('td input')[2].value);
        for (const row of rows) {
            let num = row.querySelectorAll('td input');
            if (Number(num[0].value) +
                Number(num[1].value) +
                Number(num[2].value) !== sum) {
                solved = false;
                break;
            }
            if (Number(num[0].value) ===
                Number(num[1].value) ||
                Number(num[0].value) ===
                Number(num[2].value) ||
                Number(num[1].value) ===
                Number(num[2].value)
                ) {
                solved = false;
                break;
            }
        }
        for (let i = 0; i < 3; i++) {
            if (Number(rows[0].querySelectorAll('td input')[i].value) +
                Number(rows[1].querySelectorAll('td input')[i].value) +
                Number(rows[2].querySelectorAll('td input')[i].value) !== sum) {
                solved = false;
                break;
            }
            if (Number(rows[0].querySelectorAll('td input')[i].value) ===
                Number(rows[1].querySelectorAll('td input')[i].value) ||
                Number(rows[0].querySelectorAll('td input')[i].value) ===
                Number(rows[2].querySelectorAll('td input')[i].value) ||
                Number(rows[1].querySelectorAll('td input')[i].value) ===
                Number(rows[2].querySelectorAll('td input')[i].value)
            ) {
                solved = false;
                break;
            }
        }

        if (result.children.length === 0) {
            result.appendChild(document.createElement('p'))
        }
        if (solved) {
            table.style.border = '2px solid green';
            result.children[0].textContent = "You solve it! Congratulations!";
            result.children[0].style.color = 'green';
        }
        else {
            table.style.border = '2px solid red';
            result.children[0].textContent = "NOP! You are not done yet...";
            result.children[0].style.color = 'red';
        }
    })
    clear.addEventListener('click', function (e) {
        for (const inp of document.querySelectorAll('tbody input')) {
            inp.value = '';
        }
        solved = true;
        table.removeAttribute('style');
        result.children[0].textContent = '';
        result.children[0].removeAttribute('style');
    })
}