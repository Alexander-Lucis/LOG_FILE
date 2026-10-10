// Question: Create a node.js file to Select and delete record for customer table using mysql.
// Run: node BigQ07_SelectDeleteCustomerMySQL.js (requires: npm install mysql2)

const mysql = require("mysql2");

const connection = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "YOUR_PASSWORD",
  database: "collegeDB"
});

connection.query("SELECT * FROM customers", (err, results) => {
  if (err) throw err;
  console.log("Customers before deletion:", results);

  const deleteSql = "DELETE FROM customers WHERE address = 'Highway 71'";
  connection.query(deleteSql, (err, result) => {
    if (err) throw err;
    console.log("Number of records deleted: " + result.affectedRows);

    connection.query("SELECT * FROM customers", (err, updatedResults) => {
      if (err) throw err;
      console.log("Customers after deletion:", updatedResults);
      connection.end();
    });
  });
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
