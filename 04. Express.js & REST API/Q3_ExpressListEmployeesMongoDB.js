// =============================================================================
// Topic: 4. Express.js & REST API
// Question 3: List All Employees from MongoDB
// Question: Create an Express server to list employee records and validate the response using Postman.
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

// GET API - List all employees
app.get("/employees", async (req, res) => {
  try {
    const employees = await employeeCollection.find({}).toArray();
    res.status(200).json({
      message: "Employees retrieved successfully",
      employees: employees
    });
  } catch (error) {
    res.status(500).json({
      message: "Error retrieving employees",
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
2. URL: http://localhost:3000/employees

Expected Response (200 OK):
{
  "message": "Employees retrieved successfully",
  "employees": [ ... ]
}

Sample MongoDB Documents to Populate (Insert into companyDB.employee):
[
  { "id": 101, "name": "Alice Johnson", "email": "alice@example.com", "department": "Development", "salary": 60000 },
  { "id": 102, "name": "Bob Smith", "email": "bob@example.com", "department": "HR", "salary": 45000 }
]
*/
