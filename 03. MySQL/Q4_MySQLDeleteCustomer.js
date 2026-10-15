// =============================================================================
// Topic: 3. MySQL
// Question 4: Delete a Specified Customer After Listing Customers
// Question: List all customers and delete a specified customer from MySQL.
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

  const customerId = 2;
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
