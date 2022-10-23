function notify(message) {
  let notificationDiv = document.getElementById('notification');

  if (typeof(message) === 'string' && message) {
    
    notificationDiv.textContent = message;
    notificationDiv.style.display = 'block';
    notificationDiv.addEventListener('click', ()=>{
    notificationDiv.style.display = 'none';
    })
  }
}