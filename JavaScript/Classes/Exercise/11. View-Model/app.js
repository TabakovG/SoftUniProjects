class Textbox {
    constructor(selector, regex) {
        this.elements = Array.from(document.querySelectorAll(selector));
        this._invalidSymbols = regex;
        this.value = this.elements[0].value;            
    }
    get value() { return this._value }
    set value(val) {
        this._value = val;
        this.elements.forEach(element => {
            element.value = val;
        });
    }
    get elements() { return this._elements }
    set elements(value) {
        this._elements = value;
        this._value = this.elements[0].value;
        this._elements.forEach(x=>x.addEventListener('',(e)=>{
            this.value = x.value;
        }))
    }
    isValid(){
        for (const el of this.elements) {
            let stringToMatch = el.value;
            if (this._invalidSymbols.test(stringToMatch)) {
                return false;
            }
        }
        return true;
    }
    

}

let textbox = new Textbox(".textbox", /[^a-zA-Z0-9]/);
let inputs = document.getElementsByClassName('.textbox');
console.log(textbox.isValid());
textbox.value = '@@';
console.log(textbox.isValid());

inputs.addEventListener('click', function () { console.log(textbox.value); });
document.addEventListener('')
