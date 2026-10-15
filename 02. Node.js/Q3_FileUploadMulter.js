// =============================================================================
// Topic: 2. Node.js
// Question 3: HTML File Upload Form with Express and Multer
// Question: Create a Node.js/Express server that writes an HTML form with an upload field.
// =============================================================================

const express = require("express");
const multer = require("multer");
const path = require("path");
const fs = require("fs");

const app = express();

// Ensure uploads folder exists
if (!fs.existsSync("uploads")) {
  fs.mkdirSync("uploads");
}

const storage = multer.diskStorage({
  destination: (req, file, cb) => cb(null, "uploads/"),
  filename: (req, file, cb) =>
    cb(null, Date.now() + path.extname(file.originalname))
});

const upload = multer({ storage });

app.get("/", (req, res) => {
  res.send(`
    <h2>File Upload Form</h2>
    <form action="/upload" method="POST" enctype="multipart/form-data">
      <input type="file" name="myfile" required>
      <button type="submit">Upload</button>
    </form>
  `);
});

app.post("/upload", upload.single("myfile"), (req, res) => {
  res.send("File uploaded successfully: " + req.file.originalname);
});

app.listen(3000, () => {
  console.log("Server running at http://localhost:3000");
});