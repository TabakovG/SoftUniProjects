window.addEventListener("load", solve);

function solve() {
  let firstName = document.getElementById('first-name');
  let lastName = document.getElementById('last-name');
  let age = document.getElementById('age');
  let title = document.getElementById('story-title');
  let genre = document.getElementById('genre');
  let story = document.getElementById('story');
  let preview = document.getElementById('preview-list');
  let publishBtn = document.getElementById('form-btn');

  publishBtn.addEventListener('click', (e) => {
    publishStory();
  })

  function buildElement(type, attrArr, textCont, parentDomElement) {
    let newDomElement = document.createElement(type);
    //array is in format ['attribute, value', 'attr2 , val2'...]
    if (attrArr !== undefined) {
      attrArr.forEach(element => {
        let [attribute, value] = element.split(', ');
        newDomElement.setAttribute(attribute, value);
      });
    }
    newDomElement.textContent !== undefined ? newDomElement.textContent = textCont : null;
    parentDomElement !== undefined ? parentDomElement.appendChild(newDomElement) : null;
    return newDomElement;
  }

  function publishStory() {
    if (firstName.value === ''
      || lastName.value === ''
      || age.value === ''
      || title.value === ''
      || story.value === '') {
      return;
    }

    let li = buildElement('li', ['class, story-info'], undefined, preview);
    let article = buildElement('article', undefined, undefined, li);
    let h4 = buildElement('h4', undefined, `Name: ${firstName.value} ${lastName.value}`, article);
    let ageP = buildElement('p', undefined, `Age: ${age.value}`, article);
    let titleP = buildElement('p', undefined, `Title: ${title.value}`, article);
    let genreP = buildElement('p', undefined, `Genre: ${genre.value}`, article);
    let storyP = buildElement('p', undefined, story.value, article);
    let saveBtn = buildElement('button', ['class, save-btn'], `Save Story`, li);
    let editBtn = buildElement('button', ['class, edit-btn'], `Edit Story`, li);
    let deleteBtn = buildElement('button', ['class, delete-btn'], `Delete Story`, li);

    editBtn.addEventListener('click', () => {
      firstName.value = h4.textContent.split(' ')[1];
      lastName.value = h4.textContent.split(' ')[2];
      age.value = ageP.textContent.split(': ')[1];
      title.value = titleP.textContent.split(': ')[1];
      genre.value = genreP.textContent.split(': ')[1];
      story.value = storyP.textContent;
      li.remove();
      publishBtn.removeAttribute('disabled');
    });

    saveBtn.addEventListener('click', ()=>{
      let main = document.getElementById('main');
      main.innerHTML = `<h1>"Your scary story is saved!"</h1>`;
    })

    deleteBtn.addEventListener('click', ()=>{
      li.remove();
      publishBtn.removeAttribute('disabled');
    })

    clearInputs();
    publishBtn.setAttribute('disabled', true);
  }

  function clearInputs() {

    firstName.value = '';
    lastName.value = '';
    age.value = '';
    title.value = '';
    story.value = '';
  }

}
