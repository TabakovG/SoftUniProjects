function getArticleGenerator(articles) {
    //debugger
    let container = document.getElementById('content');
    let arr = articles;
    function showArt(arr){
        let elem = document.createElement('article');
        elem.textContent = arr.shift();
        elem.textContent.length > 0 ? container.appendChild(elem) : null;
    }
    return ()=>showArt(arr);
}
