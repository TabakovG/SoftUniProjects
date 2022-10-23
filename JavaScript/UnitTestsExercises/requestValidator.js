function reqValidator(request) {
    let props = ['method', 'uri', 'version', 'message'];

    function errorAt(element) {
        let el = element === 'uri' ? 'URI' : element[0].toUpperCase() + element.substring(1);
        throw new Error(`Invalid request header: Invalid ${el}`);

    }

    for (const prop of props) {
        if (!request.hasOwnProperty(prop)) {
            errorAt(prop);
        }
    }

    if (!['GET', 'POST', 'DELETE', 'CONNECT'].includes(request.method)) {
        errorAt('method')
    }
    if (request.uri === '' 
        || (request.uri !== '*' 
        && request.uri !== request.uri.match(/[\w\.]+/g)[0])) {
        errorAt('uri');
    }

    if (!['HTTP/0.9', 'HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0'].includes(request.version)) {
        errorAt('version');
    }
    if (request.message !== '' && request.message.match(/[^\<\>\\\&\'\"]+/g)[0] !== request.message) {
        errorAt('message');
    }

    return request;
}

console.log(reqValidator({
    method: 'GET',
    uri: '',
    version: 'HTTP/1.1',
    message: ''
}
));
// console.log(reqValidator({
//     method: 'OPTIONS',
//     uri: 'git.master',
//     version: 'HTTP/1.1',
//     message: '-recursive'
//   }
//   ));
// console.log(reqValidator({
//     method: 'POST',
//     uri: 'home.bash',
//     message: 'rm -rf /*'
//   }
//   ));