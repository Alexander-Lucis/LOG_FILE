// =============================================================================
// Topic: 3. MySQL
// Question 2: Select All Customers
// Question: Select all records from customers using Node.js and MySQL.
// =============================================================================

const mysql = require("mysql2");

const connection = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "YOUR_PASSWORD",
  database: "collegeDB"
});

connection.query("SELECT * FROM customers", (err, results, fields) => {
  if (err) throw err;
  console.log("Result object:", results);
  connection.end();
});



/*
MySQL Table Setup Query:

CREATE DATABASE IF NOT EXISTS collegeDB;
USE collegeDB;

CREATE TABLE IF NOT EXISTS customers (
  id INT AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(100),
  address VARCHAR(255)
);

INSERT INTO customers (name, address) VALUES
('John', 'Highway 71'),
('Peter', 'Lowstreet 4'),
('Amy', 'Apple st 652');
*/
