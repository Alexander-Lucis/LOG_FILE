// Question: Create a Node.js file that opens the requested file and returns the content to the client. If anything goes wrong, throw a 404 err
// Run: node NodeContentClient.js

const http = require('http');
const fs = require('fs');

const server = http.createServer((req, res) => {
  // Get the requested file
  let file = '.' + req.url;

  // If root URL is requested, open index.html
  if (req.url === '/') {
    file = './index.html';
  }

  fs.readFile(file, (err, data) => {
    if (err) {
      res.writeHead(404, { 'Content-Type': 'text/plain' });
      res.end('404 - File Not Found');
      return;
    }
    res.writeHead(200, { 'Content-Type': 'text/html' });
    res.end(data);
  });
});

server.listen(3000, () => {
  console.log('Server running at http://localhost:3000');
});

/*
index.html:

<!DOCTYPE html>
<html>
<head>
  <title>Node.js File Server</title>
</head>
<body>
  <h1>Hello World!</h1>
  <p>This file is returned by the Node.js server.</p>
</body>
</html>
*/
