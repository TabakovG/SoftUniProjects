function calculator() {
    let source;
    let destination;
    let res;
    let result = {
        init(selector1, selector2, resultSelector){
            source = document.querySelector(selector1);
            destination = document.querySelector(selector2);
            res = document.querySelector(resultSelector)
        },
        add(){res.value = Number(source.value) + Number(destination.value)},
        subtract(){res.value = Number(source.value) - Number(destination.value)} 
    };
    return result;
}

const calculate = calculator (); 
calculate.init ('#num1', '#num2', '#result'); 



