// Question: Create a login component using react js consider appropriate fields.
import { useState } from "react";
import "./ReactLoginComponent.css";

function ReactLoginComponent() {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");

  const handleLogin = (e) => {
    e.preventDefault();
    if (username === "admin" && password === "1234") {
      alert("Login Successful!");
    } else {
      alert("Invalid Username or Password");
    }
  };

  return (
    <div className="login-container">
      <div className="login-box">
        <h2>Login</h2>
        <form onSubmit={handleLogin}>
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
          <button type="submit">Login</button>
        </form>
      </div>
    </div>
  );
}

export default ReactLoginComponent;

/*
ReactLoginComponent.css:

.login-container {
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
  background-color: lightgray;
}

.login-box {
  width: 350px;
  padding: 30px;
  background-color: white;
  border-radius: 10px;
  box-shadow: 0 0 10px gray;
}

.login-box h2 {
  text-align: center;
}

.login-box label {
  display: block;
  margin-top: 10px;
}

.login-box input {
  width: 100%;
  padding: 10px;
  margin-top: 5px;
  box-sizing: border-box;
}

.login-box button {
  width: 100%;
  padding: 10px;
  margin-top: 20px;
  background-color: blue;
  color: white;
  border: none;
  cursor: pointer;
}
*/
