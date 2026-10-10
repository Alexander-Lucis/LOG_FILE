// Question: Create a node.js file that Insert multiple records in "student" table using mysql.
// Run: node BigQ06_InsertMultipleStudentsMySQL.js (requires: npm install mysql2)

const mysql = require("mysql2");

const connection = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "YOUR_PASSWORD",
  database: "collegeDB"
});

const sql = "INSERT INTO student (rollno, name, marks) VALUES ?";
const values = [
  [1, "Alice", 85],
  [2, "Bob", 72],
  [3, "Charlie", 90]
];

connection.query(sql, [values], (err, result) => {
  if (err) throw err;
  console.log("Number of records inserted: " + result.affectedRows);
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
