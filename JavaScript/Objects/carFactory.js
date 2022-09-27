function carfactory(obj){

  let engine = {

  'smallEngine':{ power: 90, volume: 1800 },
  'normalEngine':{ power: 120, volume: 2400 },
  'monsterEngine':{ power: 200, volume: 3500 }

   };
  let carriage = {
    Hatchback: { type: 'hatchback', color: '' },
    Coupe: { type: 'coupe', color: '' }
  };

let car = {};
car['model'] = obj.model;
car['engine'] = Object.values(engine).find(x=>x.power >= obj.power);
car.carriage = Object.values(carriage).find(y=>y.type === obj.carriage);
car.carriage.color = obj.color;
let wheels = [];
wheels.length = 4;
let sizeW = Math.floor(obj.wheelsize) % 2 === 0 ? Math.floor(obj.wheelsize) -1 : Math.floor(obj.wheelsize);
wheels.fill(Number(sizeW));
car.wheels = wheels;

return car;

};

console.log(carfactory(
  { model: 'Opel Vectra',
  power: 110,
  color: 'grey',
  carriage: 'coupe',
  wheelsize: 17 }
));