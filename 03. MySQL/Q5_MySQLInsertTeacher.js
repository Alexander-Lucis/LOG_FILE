// =============================================================================
// Topic: 3. MySQL
// Question 5: Insert Teacher Data into MySQL
// Question: Insert teacher data into the teacher table using Node.js and MySQL.
// =============================================================================

const mysql = require("mysql2");

const connection = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "YOUR_PASSWORD",
  database: "collegeDB"
});

const teacher = ["Sara Shaikh", "sara@example.com", "Computer Science", 50000];
const sql = "INSERT INTO teacher (name, email, subject, salary) VALUES (?, ?, ?, ?)";

connection.query(sql, teacher, (err, result) => {
  if (err) throw err;
  console.log("Teacher inserted successfully");
  console.log("Result object:", result);
  connection.end();
});

/*
MySQL Table Setup Query:

CREATE DATABASE IF NOT EXISTS collegeDB;
USE collegeDB;

CREATE TABLE IF NOT EXISTS teacher (
  id INT AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(100),
  email VARCHAR(100),
  subject VARCHAR(100),
  salary INT
);
*/
