function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);
   let input = document.getElementsByTagName('textarea')[0];
   let bestRestBox = document.querySelector('#bestRestaurant p');
   let bestWorkersBox = document.querySelector('#workers p');

   function onClick() {
      let result = {};

      for (const restData of JSON.parse(input.value)) {
         let [resName, resWorkers] = restData.split(' - ');
         if (!result.hasOwnProperty(resName)) {
            result[resName] = {};
         }
         resWorkers.split(', ').forEach(w => {
            let [wName, wSalary] = w.split(' ');
            result[resName][wName] = Number(wSalary);
         });
      }
      console.log(result);
      let bestAvrg = 0;
      let bestRest = '';
      let bestRestName = '';

      for (const key in result) {
         let sumSal = 0;
         let count = 0;
         let bestSalary = 0;
         for (const empl in result[key]) {
            let emplSalary = result[key][empl];
            sumSal += emplSalary;
            if (emplSalary > bestSalary) {
               bestSalary = emplSalary;
            }
            count++;
         }
         let avrgSal = sumSal / count;
         if (avrgSal > bestAvrg) {
            bestAvrg = avrgSal;
            bestRest = `Name: ${key} Average Salary: ${bestAvrg.toFixed(2)} Best Salary: ${bestSalary.toFixed(2)}`;
            bestRestName = key;
         }

      }
      bestRestBox.textContent = bestRest;
      let sortable = [];
      for (const employee in result[bestRestName]) {
         sortable.push([employee, result[bestRestName][employee]]);
      }
      sortable.sort((a, b) => b[1] - a[1]).forEach(e => {
         bestWorkersBox.textContent +=
            `Name: ${e[0]} With Salary: ${e[1]} `
      })
   }
}