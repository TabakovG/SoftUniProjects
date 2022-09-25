function cityRecord(name, population, treasury){
  return {
    name, 
    population,
    treasury
  };
}

console.log(cityRecord('Tortuga', 7000, 15000));

function townPopulation(arr){

  let registry = {};
  arr.forEach(town => {
    let [tName, tPop] = town.split(' <-> ');

    if (registry[tName] === undefined) {
      registry[tName] = Number(tPop);
    }
    else{
      registry[tName] += Number(tPop);
    }
  });
  for (let town in registry) {
    console.log(`${town} : ${registry[town]}`);
  }
}

townPopulation(['Sofia <-> 1200000',
'Montana <-> 20000',
'New York <-> 10000000',
'Washington <-> 2345000',
'Las Vegas <-> 1000000']
);
townPopulation(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']
);

function cityTaxes(name, population, treasury){
 let city ={
  name,
  population,
  treasury,
  taxRate: 10,
  collectTaxes(){this.treasury += this.population * this.taxRate},
  applyGrowth(percentage){this.population *= 1 + percentage/100 },
  applyRecession(percentage){this.treasury *= (1 - percentage/100)} 
 }
 return city;
}

const cityA = 
  cityTaxes('Tortuga',
  7000,
  15000);
console.log(cityA);

const city =
  cityTaxes('Tortuga',
  7000,
  15000);
city.collectTaxes();
console.log(city.treasury);
city.applyGrowth(5);
console.log(city.population);


console.log('-----------------------------------------------------');

function factory(library, orders){
  let result = [];
orders.forEach(element => {
  let obj = Object.assign({},element.template)
  element.parts.forEach(action => {
    obj[action] = library[action];
  });
  result.push(obj);
});
return result;
}

//Input:

const library = {
  print: function () {
    console.log(`${this.name} is printing a page`);
  },
  scan: function () {
    console.log(`${this.name} is scanning a document`);
  },
  play: function (artist, track) {
    console.log(`${this.name} is playing '${track}' by ${artist}`);
  },
};
const orders = [
  {
    template: { name: 'ACME Printer'},
    parts: ['print']      
  },
  {
    template: { name: 'Initech Scanner'},
    parts: ['scan']      
  },
  {
    template: { name: 'ComTron Copier'},
    parts: ['scan', 'print']      
  },
  {
    template: { name: 'BoomBox Stereo'},
    parts: ['play']      
  }
];
const products = factory(library, orders);
console.log(products);

console.log('-----------------------------------------------------');

function createAssemblyLine(){
  return {

    hasClima(car){
      car.temp = 21;
      car.tempSettings = 21;
      car.adjustTemp = ()=>{
        if (car.temp < car.tempSettings) {
          car.temp++;
        }
        else if(car.temp > car.tempSettings){
          car.temp--;
        }
      }
    },
    hasAudio(car){
      car.currentTrack  = null;
      car.nowPlaying  = function(){
        if (this.currentTrack !== null) {
          console.log(`Now playing '${this.currentTrack.name}' by ${this.currentTrack.artist}`)
        }
      }
    },
    hasParktronic(car){
      car.checkDistance = (num)=>{
        if (num < 0.1) {
          console.log("Beep! Beep! Beep!");
        }
        else if(num < 0.25){
          console.log("Beep! Beep!");
        }
        else if(num < 0.5){
          console.log("Beep!");
        }
        else {
          console.log("");
        }
      }
    }
  }
}

const assemblyLine = createAssemblyLine();

const myCar = {
    make: 'Toyota',
    model: 'Avensis'
};

assemblyLine.hasClima(myCar);
console.log(myCar.temp);
myCar.tempSettings = 18;
myCar.adjustTemp();
console.log(myCar.temp);

assemblyLine.hasAudio(myCar);
myCar.currentTrack = {
    name: 'Never Gonna Give You Up',
    artist: 'Rick Astley'
};
myCar.nowPlaying();

assemblyLine.hasParktronic(myCar);
myCar.checkDistance(0.4);
myCar.checkDistance(0.2);

console.log(myCar);

console.log('-----------------------------------------------------');


function jsonToHtml(input){

  let arr = JSON.parse(input);
  let result = '<table>\n'
  result += '   <tr>';

  for (let key in arr[0]) {
    result += `<th>${escape(key.toString())}</th>`;
  }

  result += '</tr>\n';

  arr.forEach(element => {
    result += '   <tr>';

    for (let prop in element) {
      result += `<td>${escape(element[prop].toString())}</td>`;
    }
    result += '</tr>\n';
  });

  result += '</table>'

  function escape(strValue){
    return strValue.replace('<', '&lt;').replace('>','&gt;');
  }

  console.log(result);
}

jsonToHtml(`[
  {"Name":"Pesho","Score":4,"Grade":8},
  {"Name":"Gosho","Score":5,"Grade":8},
  {"Name":"Angel","Score":5.50,"Grade":10}
]`
);