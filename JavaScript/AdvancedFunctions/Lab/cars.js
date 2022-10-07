function createCar(arr) {
  let cars = {};
  let builder = {
    create(name, inh, base) {
        cars[name] = inh ? Object.create(cars[base]) : {};
      },
    // inherit(name, baseName){cars[name]=cars[baseName]},
    set(name, key, value) { cars[name][key] = value },
    print(name) {
      let info = []; 
      for (const key in cars[name]) {
        info.push(`${key}:${cars[name][key]}`);
      }
      console.log(info.join(','))
    }
  }

  for (const actionData of arr) {
    let [com, val1, val2, val3] = actionData.split(' ');

    builder[com](val1, val2, val3);
  }

}

createCar(['create c1',
  'create c2 inherit c1',
  'set c1 color red',
  'set c2 model new',
  'print c1',
  'print c2']
);