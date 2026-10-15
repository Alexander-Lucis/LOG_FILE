// =============================================================================
// Topic: 6. React.js
// Question 5: Counter Using useState
// Question: Create a React component illustrating useState.
// =============================================================================

import { useState } from "react";

function IllustrateUseState() {
  const [count, setCount] = useState(0);

  return (
    <div>
      <h1>useState Example</h1>
      <h2>Count: {count}</h2>
      <button onClick={() => setCount(count + 1)}>Increment</button>
      <button onClick={() => setCount(count - 1)}>Decrement</button>
    </div>
  );
}

export default IllustrateUseState;