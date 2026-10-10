// Question: Create a react a component to render user name and update user name when there is change [use useEffect and useState]
import { useState, useEffect } from "react";

function ReactRenderUsername() {
  const [name, setName] = useState("Ujwala");

  useEffect(() => {
    console.log("User name changed:", name);
  }, [name]);

  return (
    <div>
      <h1>User Name</h1>
      <h2>Hello, {name}</h2>
      <input
        type="text"
        value={name}
        onChange={(e) => setName(e.target.value)}
        placeholder="Enter your name"
      />
    </div>
  );
}

export default ReactRenderUsername;
