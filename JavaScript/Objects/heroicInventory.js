function createRegister(arr){
  let result = [];

  arr.forEach(element => {
    let [name,level,itemsStr] = element.split(' / ');
    let tempObj = {
      name,
      level: Number(level),
      items: itemsStr ? []=itemsStr.split(', ') : []
    }
    result.push(tempObj);
  });

  console.log(JSON.stringify(result));
}
createRegister(['Isacc / 25 / Apple, GravityGun',
'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara']
);