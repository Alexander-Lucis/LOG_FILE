// =============================================================================
// Topic: 4. Express.js & REST API
// Question 6: Insert Teacher Data into MongoDB with Express
// Question: Create a Node.js Express server to insert teacher data into a MongoDB teacher collection.
// =============================================================================

const express = require("express");
const { MongoClient } = require("mongodb");

const app = express();
app.use(express.json());

const url = "mongodb://127.0.0.1:27017";
const client = new MongoClient(url);
let db;

async function connectDB() {
  await client.connect();
  db = client.db("collegeDB");
  console.log("MongoDB Connected Successfully");
}
connectDB();

app.post("/teacher", async (req, res) => {
  try {
    const teacher = {
      name: req.body.name,
      email: req.body.email,
      subject: req.body.subject,
      salary: req.body.salary
    };

    const result = await db.collection("teacher").insertOne(teacher);
    res.status(201).json({
      message: "Teacher inserted successfully",
      teacher: teacher,
      insertedId: result.insertedId
    });
  } catch (error) {
    res.status(500).json({
      message: "Error inserting teacher",
      error: error.message
    });
  }
});

app.listen(3000, () => {
  console.log("Server running on http://localhost:3000");
});
