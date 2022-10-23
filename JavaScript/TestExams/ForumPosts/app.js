window.addEventListener("load", solve);

function solve() {
  let title = document.getElementById('post-title');
  let category = document.getElementById('post-category');
  let content = document.getElementById('post-content');
  let publish = document.getElementById('publish-btn');
  let review = document.getElementById('review-list');
  let uploaded = document.getElementById('published-list');
  let clearB = document.getElementById('clear-btn');

  publish.addEventListener('click', (e) => {
    publishPost();
  });

  function publishPost() {
    if (!(title.value && category.value && content.value)) {
      return;
    }
    let post = buildElement('li', 'rpost');
    let article = buildElement('article', undefined, undefined, post);
    let aTitle = buildElement('h4', undefined, title.value, article);
    let aCateg = buildElement('p', undefined, 'Category: ' + category.value, article);
    let aDescr = buildElement('p', undefined, 'Content: ' + content.value, article);
    let approve = buildElement('button', 'action-btn approve', 'Approve', post);
    let edit = buildElement('button', 'action-btn edit bla-bla', 'Edit', post);

    approve.addEventListener('click', (e) => {
      edit.remove();
      approve.remove();
      uploaded.appendChild(post);
    });
    edit.addEventListener('click', (e) => {
      title.value = aTitle.textContent;
      category.value = aCateg.textContent.substring(10);
      content.value = aDescr.textContent.substring(9);
      post.remove();
    });

    review.appendChild(post);

    title.value = '';
    category.value = '';
    content.value = '';

  }

  function buildElement(type, classes, textCont, parentEl) {
    let newE = document.createElement(type);
    classes !== undefined ? newE.classList = classes : null;
    newE.textContent !== undefined ? newE.textContent = textCont : null;
    parentEl !== undefined ? parentEl.appendChild(newE) : null;
    return newE;
  }

  clearB.addEventListener('click', (e)=>{
    uploaded.innerHTML = '';
  })
}
