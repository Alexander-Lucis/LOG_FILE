// =============================================================================
// Topic: 4. Express.js & REST API
// Question 2: Register REST API
// Question: Create an Express server with a register REST API and validate it using Postman.
// =============================================================================

const express = require("express");
const app = express();
const PORT = 3000;

app.use(express.json());

// Register REST API
app.post("/register", (req, res) => {
  const { name, email, username, password } = req.body;

  console.log("Registration Request:", { name, email, username });

  if (!name || !email || !username || !password) {
    return res.status(400).json({
      message: "All fields are required"
    });
  }

  res.status(201).json({
    message: "Registration successful",
    user: { name, email, username }
  });
});

app.listen(PORT, () => {
  console.log(`Server running at http://localhost:${PORT}`);
});

/*
Postman Test Details:
1. Method: POST
2. URL: http://localhost:3000/register
3. Headers: Content-Type: application/json
4. Body (raw JSON):

{
  "name": "John Doe",
  "email": "john@example.com",
  "username": "johndoe",
  "password": "password123"
}

Expected Response (201 Created):
{
  "message": "Registration successful",
  "user": {
    "name": "John Doe",
    "email": "john@example.com",
    "username": "johndoe"
  }
}
*/
