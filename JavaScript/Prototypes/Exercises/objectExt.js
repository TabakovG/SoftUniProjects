function extensibleObject() {
    let result = {};
    result.extend = (obj) => {
        Object.setPrototypeOf(result, obj);
        for (const prop in Object.getOwnPropertyDescriptors(obj)) {
            console.log(prop);
            if (typeof(obj[prop]) !== 'function') {
                result[prop] = obj[prop];
            }
        }

    }
    return result;
}

let t = {
    fight: function (target) { return `object fights with ${target}` },
    health: 100,
    mana: 50
};


const myObj = extensibleObject();

const template = {
    extensionMethod: function () { console.log("From extension method") },
    extensionProperty: 'someString'
}
myObj.extend(t);

console.log(myObj.hasOwnProperty('fight'));

