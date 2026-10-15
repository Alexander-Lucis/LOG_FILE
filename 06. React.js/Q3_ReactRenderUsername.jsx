// =============================================================================
// Topic: 6. React.js
// Question 3: Update Username Using useState and useEffect
// Question: Render a username and update it when the input changes using useEffect and useState.
// =============================================================================

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