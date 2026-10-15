// =============================================================================
// Topic: 6. React.js
// Question 8: Display a List of Students
// Question: Create a React component to display student details using sample data.
// =============================================================================

import React from "react";

function ReactStudentList() {
  const students = [
    { id: 1, name: "Rahul", age: 21, course: "BCA" },
    { id: 2, name: "Priya", age: 22, course: "BBA" },
    { id: 3, name: "Amit", age: 21, course: "BCS" },
    { id: 4, name: "Sneha", age: 22, course: "BCA" },
    { id: 5, name: "Pooja", age: 21, course: "BCS" }
  ];

  return (
    <div>
      <h1>Student List</h1>
      <ul>
        {students.map((student) => (
          <li key={student.id}>
            {student.name} - {student.age} - {student.course}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default ReactStudentList;