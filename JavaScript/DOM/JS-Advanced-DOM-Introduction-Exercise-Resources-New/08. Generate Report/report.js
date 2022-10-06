function generateReport() {
    let result = [];
    let rows = document.querySelectorAll('tr');
    let reportBox = document.getElementById('output');

    for (let row = 1; row < rows.length; row++) {
        let tempObj = {};

        for (let headIndex = 0; headIndex < rows[0].children.length; headIndex++) {
            if (rows[0].children[headIndex].children[0].checked) {
                tempObj[rows[0].children[headIndex].children[0].name] = rows[row].children[headIndex].textContent
            }    
        }
        result.push(tempObj);
        
    }
    reportBox.textContent = JSON.stringify(result, null, "\t");
    };
