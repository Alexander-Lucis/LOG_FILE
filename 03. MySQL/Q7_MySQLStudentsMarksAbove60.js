// =============================================================================
// Topic: 3. MySQL
// Question 7: List Students Whose Marks Are Greater Than 60
// Question: List students whose marks are greater than 60 using MySQL.
// =============================================================================

const mysql = require("mysql2");

const connection = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "YOUR_PASSWORD",
  database: "collegeDB"
});

connection.query(
  "SELECT * FROM student WHERE marks > ?",
  [60],
  (err, results) => {
    if (err) throw err;
    console.log("Students scoring above 60:", results);
    connection.end();
  }
);




/*
MySQL Query:

SELECT * FROM student WHERE marks > 60;
*/
