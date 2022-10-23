class List {
    constructor() {
        this.sortedList = [];
        this.size=0;
    }
    add(num) {
        this.sortedList.push(num);
        this.sortedList = this.sortedList.sort((a, b) => a - b);
        this.size++;
    }
    remove(index){
        if(index >= 0 && index < this.sortedList.length){
            this.sortedList.splice(index,1);
        this.size--;
        }
        else{
            throw new Error('Index out of rande exeption!');
        }
    }
    get(index){
        if(index >= 0 && index < this.sortedList.length){
            return this.sortedList[index];
        }
        else{
            throw new Error('Index out of rande exeption!');
        }
    }
}

let list = new List();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1)); 
list.remove(1);
console.log(list.get(1));
console.log(list.size)
console.log(list.hasOwnProperty())

