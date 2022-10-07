function currencyFormatter(separator, symbol, symbolFirst, value) {
  let result = Number(value).toFixed(2).replace('.', separator);
  symbolFirst ? result = symbol + " " + result : result += " " + symbol;
  return result;
}

// function partial(separator, symbol, symbolFirst, forma) {
//   return function forma(value) {
//     let result = Number(value).toFixed(2).replace('.', separator);
//     symbolFirst ? result = symbol + " " + result : result += " " + symbol;
//     return result;
//   }
// }

// console.log(formatter(',', '$', true, 24));
function createFormatter(separator, symbol, symbolFirst, currencyFormatter) {
  let formatter = function(value) {
      return currencyFormatter(separator, symbol, symbolFirst, value);
  }
  return formatter;
}
  let dollarFormatter = createFormatter(',', '$', true, currencyFormatter);
  console.log(dollarFormatter(5345));   // $ 5345,00
  console.log(dollarFormatter(3.1429)); // $ 3,14
  console.log(dollarFormatter(2.709));  // $ 2,71

