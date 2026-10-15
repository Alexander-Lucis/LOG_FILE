// =============================================================================
// Topic: 4. Express.js & REST API
// Question 1: Login REST API
// Question: Create an Express server with a login REST API and validate its response using Postman.
// =============================================================================

const express = require("express");
const app = express();
const PORT = 3000;

app.use(express.json());

// Login REST API
app.post("/login", (req, res) => {
  const username = req.body.username;
  const password = req.body.password;

  console.log("Username:", username);
  console.log("Password:", password);

  if (username === "admin" && password === "12345") {
    console.log("Login successful");
    res.status(200).json({
      message: "Login successful",
      username: username
    });
  } else {
    console.log("Login failed");
    res.status(401).json({
      message: "Invalid username or password"
    });
  }
});

app.listen(PORT, () => {
  console.log(`Server running at http://localhost:${PORT}`);
});

/*
Postman Test Details:
1. Method: POST
2. URL: http://localhost:3000/login
3. Headers: Content-Type: application/json
4. Body (raw JSON):

{
  "username": "admin",
  "password": "12345"
}

Expected Response (200 OK):
{
  "message": "Login successful",
  "username": "admin"
}
*/
