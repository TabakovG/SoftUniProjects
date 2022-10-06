function sortedList() {
  let numbers = [];
  let result = {
    numbers,
    size: 0,
    add: (x) => {
      numbers.push(x)
      result.size++;
      if (numbers.length > 1) {
        numbers.sort((x, y) => x - y)
      }
    },
    remove: (i) => {
      if (i > -1 && i < numbers.length) {
        numbers.splice(i, 1);
        result.size--;
        if (numbers.length > 1) {
          numbers.sort((x, y) => x - y);
        }
      }
    },
    get: (index) => {
      if (index > -1 && index < numbers.length) {
        return numbers[index];
      }
    }
  };

  return result;
}

let list = sortedList();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1));
list.remove(1);
console.log(list.get(1));
console.log(list.size);
