function deleteByEmail() {
    let tableRows = document.querySelectorAll('table tbody tr td');
    let searchBar = document.getElementsByName('email')[0];
    // debugger;
    let result = "Not found.";
    for (const row of tableRows) {
        if (row.textContent === searchBar.value) {
            let tbd = row.parentElement;
            tbd.parentElement.removeChild(tbd);
            result = "Deleted.";
        }
    }

    document.getElementById('result').textContent = result;

}