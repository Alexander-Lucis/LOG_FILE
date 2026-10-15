// =============================================================================
// Topic: 8. React Hooks
// Question 1: useState and useEffect: Username Update
// Question: Render a username and update it using useState/useEffect.
// =============================================================================

import { useState, useEffect } from "react";

function HooksUserNameEffect() {
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

export default HooksUserNameEffect;