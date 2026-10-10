// Question: Create a register component using react js consider appropriate fields.
import { useState } from "react";
import "./ReactRegisterComponent.css";

function ReactRegisterComponent() {
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [mobile, setMobile] = useState("");

  const handleRegister = (e) => {
    e.preventDefault();
    alert("Registration Successful!");
  };

  return (
    <div className="register-container">
      <div className="register-box">
        <h2>Registration Form</h2>
        <form onSubmit={handleRegister}>
          <label>Name</label>
          <input
            type="text"
            placeholder="Enter Name"
            value={name}
            onChange={(e) => setName(e.target.value)}
            required
          />
          <label>Email</label>
          <input
            type="email"
            placeholder="Enter Email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            required
          />
          <label>Username</label>
          <input
            type="text"
            placeholder="Enter Username"
            value={username}
            onChange={(e) => setUsername(e.target.value)}
            required
          />
          <label>Password</label>
          <input
            type="password"
            placeholder="Enter Password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            required
          />
          <label>Mobile Number</label>
          <input
            type="tel"
            placeholder="Enter Mobile Number"
            value={mobile}
            onChange={(e) => setMobile(e.target.value)}
            required
          />
          <button type="submit">Register</button>
        </form>
      </div>
    </div>
  );
}

export default ReactRegisterComponent;

/*
ReactRegisterComponent.css:

.register-container {
  display: flex;
  justify-content: center;
  align-items: center;
  min-height: 100vh;
  background-color: lightgray;
}

.register-box {
  width: 350px;
  padding: 30px;
  background-color: white;
  border-radius: 10px;
  box-shadow: 0 0 10px gray;
}

.register-box h2 {
  text-align: center;
}

.register-box label {
  display: block;
  margin-top: 10px;
}

.register-box input {
  width: 100%;
  padding: 10px;
  margin-top: 5px;
  box-sizing: border-box;
}

.register-box button {
  width: 100%;
  padding: 10px;
  margin-top: 20px;
  background-color: green;
  color: white;
  border: none;
  border-radius: 5px;
  cursor: pointer;
}
*/
