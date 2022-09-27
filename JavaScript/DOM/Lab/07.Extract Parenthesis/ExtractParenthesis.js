function extract(content) {
  let source = document.getElementById(content).textContent;
  let pattern = /\([\w\s]*\)/g;
  let arr = source.match(pattern);
  return arr.join("; ");
}