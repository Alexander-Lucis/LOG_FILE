// =============================================================================
// Topic: 3. MySQL
// Question 6: Delete a Student by Roll Number
// Question: Delete a student record by roll number using MySQL.
// =============================================================================

const mysql = require("mysql2");

const connection = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "YOUR_PASSWORD",
  database: "collegeDB"
});

const rollno = 2; // Roll number to delete

connection.query(
  "DELETE FROM student WHERE rollno = ?",
  [rollno],
  (err, result) => {
    if (err) throw err;
    console.log("Delete result object:", result);
    console.log("Rows deleted:", result.affectedRows);
    connection.end();
  }
);

/*
MySQL Query:

DELETE FROM student WHERE rollno = ?;
*/
