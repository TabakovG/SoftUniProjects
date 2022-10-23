(function solve() {
    Array.prototype.last = function () {
        return this[this.length - 1];
    }
    Array.prototype.skip = function (n) {
        let result = [];
        for (let i = n; i < this.length; i++) {
            result.push(this[i]);
        }
        return result;
    }
    Array.prototype.take = function (n) {
        let result = [];
        for (let i = 0; i < n; i++) {
            result[i] = this[i];
        }
        return result;
    }
    Array.prototype.sum = function (n) {
        return this.reduce((acc, x) => { return acc + x }, 0);
    }
    Array.prototype.average = function () {
        let num = this.length;
        return this.reduce((acc, x) => { return acc + x }, 0) / num;
    }

})()