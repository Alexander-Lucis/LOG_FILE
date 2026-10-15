// =============================================================================
// Topic: 4. Express.js & REST API
// Question 5: Search an Employee by Email in MongoDB
// Question: Create an Express server to search an employee by email and validate the response using Postman.
// =============================================================================

const express = require("express");
const { MongoClient } = require("mongodb");

const app = express();
const PORT = 3000;

const url = "mongodb://127.0.0.1:27017";
const client = new MongoClient(url);
const dbName = "companyDB";
let employeeCollection;

async function connectDB() {
  try {
    await client.connect();
    console.log("MongoDB connected successfully");
    const db = client.db(dbName);
    employeeCollection = db.collection("employee");
  } catch (error) {
    console.log("MongoDB connection error:", error);
  }
}

// Search employee by email
app.get("/employee", async (req, res) => {
  try {
    const email = req.query.email;
    const employee = await employeeCollection.findOne({ email: email });

    if (employee) {
      res.status(200).json({
        message: "Employee found successfully",
        employee: employee
      });
    } else {
      res.status(404).json({
        message: "Employee not found"
      });
    }
  } catch (error) {
    res.status(500).json({
      message: "Server error",
      error: error.message
    });
  }
});

app.listen(PORT, async () => {
  await connectDB();
  console.log(`Server running at http://localhost:${PORT}`);
});

/*
Postman Test Details:
1. Method: GET
2. URL: http://localhost:3000/employee?email=john@example.com

Expected Response (200 OK):
{
  "message": "Employee found successfully",
  "employee": {
    "name": "John Doe",
    "email": "john@example.com",
    "department": "Engineering",
    "salary": 60000
  }
}

Sample MongoDB Document (Insert into companyDB.employee):
{
  "name": "John Doe",
  "email": "john@example.com",
  "department": "Engineering",
  "salary": 60000
}
*/
