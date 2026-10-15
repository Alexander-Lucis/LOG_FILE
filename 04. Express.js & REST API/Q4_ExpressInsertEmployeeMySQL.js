// =============================================================================
// Topic: 4. Express.js & REST API
// Question 4: Insert Employee into a MySQL Database
// Question: Create an Express API to insert an employee into MySQL.
// =============================================================================

const express = require("express");
const mysql = require("mysql2");

const app = express();
app.use(express.json());

const db = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "YOUR_PASSWORD",
  database: "collegeDB"
});

app.post("/employees", (req, res) => {
  const { name, email, department, salary } = req.body;
  const sql = "INSERT INTO employee (name, email, department, salary) VALUES (?, ?, ?, ?)";

  db.query(sql, [name, email, department, salary], (err, result) => {
    if (err) return res.status(500).json({ error: err.message });
    res.status(201).json({
      message: "Employee inserted successfully",
      insertId: result.insertId
    });
  });
});

app.listen(3000, () => {
  console.log("Server running at http://localhost:3000");
});

/*
MySQL Table Setup Query:

CREATE DATABASE IF NOT EXISTS collegeDB;
USE collegeDB;

CREATE TABLE IF NOT EXISTS employee (
  id INT AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(100),
  email VARCHAR(100),
  department VARCHAR(50),
  salary INT
);
*/
