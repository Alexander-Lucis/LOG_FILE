// =============================================================================
// Topic: 2. Node.js
// Question 2: File Server with a 404 Response
// Question: Open the requested file and return its content to the client; return 404 if it is not found.
// =============================================================================

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