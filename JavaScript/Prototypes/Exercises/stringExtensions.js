(function solve() {
    String.prototype.ensureStart = function (str) {
        let result = this.startsWith(str) ? this.toString() : str + this.toString();
        return result;
    }
    String.prototype.ensureEnd = function (str) {
        let result =  this.endsWith(str) ? this.toString() : this.toString() + str;
        return result;
    }
    String.prototype.isEmpty = function () {
        return this.toString() === "";
    }
    String.prototype.truncate = function (n) {
        let result = '';
        if (this.length <= n) {
            result = this.toString();
        }
        else if (n < 4) {
            for (let i = 0; i < n; i++) {
                result += '.';
            }

        }
        else {
            let arr = this.split(' ');
            while (arr.length > 1) {
                arr.pop();
                let newStr = arr.join(' ');
                newStr += '...';
                if (newStr.length <= n) {
                    return newStr;
                }
            }
            result = arr[0].substring(0, n - 3) + '...';
        }
        return result;
    }

    String.format = function (str, ...params) {
        let result = str;
        for (let i = 0; i < params.length; i++) {
            result = result.replace(`{${i}}`, params[i]);
        }
        return result;
    }


    // let str = 'my string';
    // console.log(str);
    // str = str.ensureStart('my');
    // console.log(str);

    // str = str.ensureStart('hello ');
    // console.log(str);
    // str = str.ensureEnd('newend');
    // console.log(str);
    // str = str.ensureEnd('newend');
    // console.log(str);
    // str.isEmpty();
    // console.log(str);


    // str = str.truncate(16);
    // console.log(str);

    // str = str.truncate(14);
    // console.log(str);

    // str = str.truncate(8);
    // console.log(str);

    // str = str.truncate(4);
    // console.log(str);

    // str = str.truncate(2);
    // console.log(str);

    // str = String.format('The {0} {1} fox',
    //     'quick', 'brown');
    // console.log(str);

    // str = String.format('jumps {0} {1}',
    //     'dog');
    // console.log(str);
})()