// =============================================================================
// Topic: 2. Node.js
// Question 5: Insert Multiple Student Records
// Question: Insert multiple records in the student table and display the result object.
// =============================================================================

const mysql = require("mysql2");

const connection = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "YOUR_PASSWORD",
  database: "collegeDB"
});

const sql = "INSERT INTO student (rollno, name, marks) VALUES ?";
const values = [
  [1, "Ayesha", 78],
  [2, "Rahul", 65],
  [3, "Sneha", 54]
];

connection.query(sql, [values], (err, result) => {
  if (err) throw err;
  console.log("Result object:", result);
  connection.end();
});

/*
MySQL Table Setup Query:

CREATE DATABASE IF NOT EXISTS collegeDB;
USE collegeDB;

CREATE TABLE IF NOT EXISTS student (
  rollno INT PRIMARY KEY,
  name VARCHAR(50),
  marks INT
);
*/
