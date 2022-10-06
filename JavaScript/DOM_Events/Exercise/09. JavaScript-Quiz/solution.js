function solve() {
  let sections = document.getElementsByTagName('section');
  let resultBox = document.querySelector('.results-inner h1');
  let result = 0;
  let index = 0;
  let section = sections[index];
  let correct = ['onclick', 'JSON.stringify()', 'A programming API for HTML and XML documents'];
  
  document.getElementById('quizzie').addEventListener('click', function (event) {
    if (event.target.classList[0] === 'answer-text') {
      if (event.target.textContent === correct[index]) {
        result++;
      }
      section.style.display = 'none';
      index++;
      if (index < sections.length) {
        section = sections[index];
        section.style.display = 'block';
      }
      else{
        let ul = document.getElementById('results');
        ul.style.display = 'block';
        if (result === sections.length) {
          resultBox.textContent = "You are recognized as top JavaScript fan!";
        }
        else{
          resultBox.textContent = `You have ${result} right answers`;
        }
      }
    }
  })
}
