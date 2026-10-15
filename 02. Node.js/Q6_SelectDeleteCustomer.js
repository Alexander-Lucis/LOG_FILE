// =============================================================================
// Topic: 2. Node.js
// Question 6: Display Customers, Then Delete a Specified Customer
// Question: Select all customers and delete the specified record.
// =============================================================================

const mysql = require("mysql2");

const connection = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "YOUR_PASSWORD",
  database: "collegeDB"
});

connection.query("SELECT * FROM customers", (err, rows) => {
  if (err) throw err;
  console.log("All customers:", rows);

  const customerId = 2; // Change this ID as required
  connection.query(
    "DELETE FROM customers WHERE id = ?",
    [customerId],
    (err, result) => {
      if (err) throw err;
      console.log("Delete result object:", result);
      connection.end();
    }
  );
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
*/
