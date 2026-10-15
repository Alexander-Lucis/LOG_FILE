// =============================================================================
// Topic: 5. JWT Authentication
// Question 1: Generate a JWT Token in the Login API Response
// Question: Create an Express login API that generates a JWT token in its response.
// =============================================================================

const express = require("express");
const jwt = require("jsonwebtoken");

const app = express();
const PORT = 3000;
const SECRET_KEY = "mysecretkey";

app.use(express.json());

app.post("/login", (req, res) => {
  const { username, password } = req.body;

  if (username === "admin" && password === "12345") {
    const token = jwt.sign(
      { username: username },
      SECRET_KEY,
      { expiresIn: "1h" }
    );

    res.json({
      message: "Login successful",
      token: token
    });
  } else {
    res.status(401).json({
      message: "Invalid username or password"
    });
  }
});

app.listen(PORT, () => {
  console.log(`Server running at http://localhost:${PORT}`);
});
