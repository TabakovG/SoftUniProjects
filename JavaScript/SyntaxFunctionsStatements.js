function FruitPrice(fruitType, weight, price ){
let weightInKg = weight/1000;
let cost = weightInKg*price;
console.log(`I need $${cost.toFixed(2)} to buy ${weightInKg.toFixed(2)} kilograms ${fruitType}.`);
}
FruitPrice('orange', 2500, 1.80);

function greatestCommonDivisor(num1,num2){
  let smallerNum = num1 < num2 ? num1 : num2;
  for (let index = smallerNum; index > 0; index--) {
    if (num1 % index === 0 && num2 % index === 0) {
      console.log(index);
      break;
    }
    
  }
}
greatestCommonDivisor(15,5);
greatestCommonDivisor(2154, 458);

function sameNumbers(num){
let sum = 0;
let numToStr = num+'';
let same = true;

for (let index = 0; index < numToStr.length; index++) {
  if (numToStr[index] !== numToStr[0]) {
    same = false;
  }
  sum += Number(numToStr[index]);
}

console.log(same);
console.log(sum);
}
sameNumbers(1234)

function previousDay(year, month, day){
  let newDate = new Date(year, month+1, day);
  newDate.setDate(newDate.getDate()-1);
  newDate.da

  console.log(`${newDate.getFullYear()}-${newDate.getMonth()-1}-${newDate.getDate()}`);
}
previousDay(2016, 9, 30);
previousDay(2016, 10, 1);

function TimeToWalk(steps, footprint, speed){
  let distanceInKm = steps * footprint / 1000;
  let restsInMin = Math.floor(distanceInKm / 0.5);
  let timeInHours = distanceInKm / speed;
  let finalTimeSec = Math.round(timeInHours*3600+restsInMin*60);

  let hours = Math.floor(finalTimeSec/3600);
  hours = hours.toString().length > 1 ? hours.toString() : '0'+ hours.toString();
  let seconds = finalTimeSec % 60;
  seconds = seconds.toString().length > 1 ? seconds.toString() : '0'+ seconds.toString();
  let minutes = Math.floor(((finalTimeSec-seconds) % 3600)/60)
  minutes = minutes.toString().length > 1 ? minutes.toString() : '0'+ minutes.toString();


  console.log(`${hours}:${minutes}:${seconds}`);
}

TimeToWalk(2564, 0.70, 5.5);

function roadRadar(speed, area){
  const Motorway_Max_Speed = 130;
  const Interstate_Max_Speed = 90;
  const City_Max_Speed = 50;
  const Residential_Max_Speed = 20;

  let speedLimits = {
    'motorway':Motorway_Max_Speed , 
    'interstate':Interstate_Max_Speed,
    'city':City_Max_Speed,
    'residential':Residential_Max_Speed
  }

  let limit = speedLimits[area.toLowerCase()];

  if (limit >= speed) {
    console.log(`Driving ${speed} km/h in a ${limit} zone`);
  }
  else if(speed > limit){
    let speeding = speed-limit;
    let status = speeding <= 20 ? 'speeding' : speeding <= 40 ? 'excessive speeding' : 'reckless driving';
    console.log(`The speed is ${speeding} km/h faster than the allowed speed of ${limit} - ${status}`);
  }
}
roadRadar(40, 'city');
roadRadar(20, 'residential');
roadRadar(120, 'interstate');

function Cooking(num, operation1, operation2, operation3, operation4, operation5){
let operations = [operation1, operation2, operation3, operation4, operation5];
let result = Number(num);
for (let i = 0; i < operations.length; i++) {
  switch (operations[i]) {
    case 'chop': result /= 2; break;
    case 'dice': result = Math.sqrt(result); break;
    case 'spice': result += 1; break;
    case 'bake': result *= 3; break;
    case 'fillet': result *= 0.8; break;
  }
  console.log(parseFloat(result.toFixed(3)));
}

}
Cooking('9', 'dice', 'spice', 'chop', 'bake', 'fillet');

function ValidityCheck(x1, y1, x2, y2){
  let firstPoint = Math.sqrt(Math.pow(0-x1, 2) + Math.pow(0-y1, 2));
  let secPoint = Math.sqrt(Math.pow(0-x2, 2) + Math.pow(0-y2, 2));
  let thirdPoint = Math.sqrt(Math.pow(x2-x1, 2) + Math.pow(y2-y1, 2));

  let firstResult = Number.isInteger(firstPoint) ? 'valid': 'invalid';
  let secResult = Number.isInteger(secPoint) ? 'valid': 'invalid';
  let thirdResult = Number.isInteger(thirdPoint) ? 'valid': 'invalid';

  console.log(`{${x1}, ${y1}} to {0, 0} is ${firstResult}` );
  console.log(`{${x2}, ${y2}} to {0, 0} is ${secResult}` );
  console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is ${thirdResult}` );

}
ValidityCheck(3, 0, 0, 4);
ValidityCheck(2, 1, 1, 1);

function WordsToUpper(input){
  let words = /\w+/g;
  let arr = input.match(words);

  console.log(arr.join(', ').toUpperCase());
}
WordsToUpper('Hi, how are you?');