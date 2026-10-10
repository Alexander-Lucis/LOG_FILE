const http = require('http');
http.createServer((req, res) => {
    res.end('Hello from Node.js server running in Docker!');
}).listen(3000, '0.0.0.0',() => {
    console.log( 'Server is running on port 3000')
});