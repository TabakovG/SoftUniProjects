function encodeAndDecodeMessages() {
    let btns = document.getElementsByTagName('button');
    let encode = btns[0];
    let decode = btns[1];

    let source = document.getElementsByTagName('textarea')[0];
    let destination = document.getElementsByTagName('textarea')[1];

    encode.addEventListener('click', function(event){
        let result ='';
        for (const char of source.value) {
            result += String.fromCharCode(
                char.charCodeAt(0)+1
                );
        }
        destination.value = result;
        source.value = '';
    })
    decode.addEventListener('click', function(event){
        let result ='';
        for (const char of destination.value) {
            result += String.fromCharCode(
                char.charCodeAt(0)-1
                );
        }
        destination.value = result;
    })

}