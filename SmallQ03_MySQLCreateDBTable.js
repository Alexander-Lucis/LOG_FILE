// Question: Create a Node.js file that demonstrates create database and table in MySQL
// Run: node MySQLCreateDBTable.js (requires: npm install mysql2)

const mysql = require("mysql2");

const connection = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "YOUR_PASSWORD"
});

connection.connect((err) => {
  if (err) throw err;
  console.log("Connected to MySQL");

  connection.query("CREATE DATABASE IF NOT EXISTS collegeDB", (err) => {
    if (err) throw err;
    console.log("Database created");

    connection.changeUser({ database: "collegeDB" }, (err) => {
      if (err) throw err;
      const sql = `CREATE TABLE IF NOT EXISTS student (
        rollno INT PRIMARY KEY,
        name VARCHAR(50),
        marks INT
      )`;
      connection.query(sql, (err) => {
        if (err) throw err;
        console.log("Student table created");
        connection.end();
      });
    });
  });
});
