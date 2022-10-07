function outer(arr) {
  let word = [];
  for (const str of arr) {
    let [command, value] = str.split(' ');

    let result = {
      add(val) { word.push(val) },
      remove(val) { word = word.filter(x => x !== val) },
      print() { console.log(word.join(',')) }
    };
    result[command](value);
  }
}

outer(['add hello', 'add again', 'remove hello', 'add again', 'print']);
outer(['add pesho', 'add george', 'add peter', 'remove peter', 'print']);
outer(['print']);