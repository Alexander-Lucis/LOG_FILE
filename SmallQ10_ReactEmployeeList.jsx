// Question: Create react component to display list of employees consider any random employee data.
import React from "react";

function ReactEmployeeList() {
  const employees = [
    { id: 1, name: "Rahul Patil", department: "IT", salary: 45000 },
    { id: 2, name: "Sneha Sharma", department: "HR", salary: 40000 },
    { id: 3, name: "Amit Kulkarni", department: "Finance", salary: 50000 },
    { id: 4, name: "Priya Deshmukh", department: "Marketing", salary: 42000 }
  ];

  return (
    <div>
      <h2>Employee List</h2>
      {employees.map((employee) => (
        <div key={employee.id}>
          <h3>{employee.name}</h3>
          <p>Department: {employee.department}</p>
          <p>Salary: ₹{employee.salary}</p>
          <hr />
        </div>
      ))}
    </div>
  );
}

export default ReactEmployeeList;
