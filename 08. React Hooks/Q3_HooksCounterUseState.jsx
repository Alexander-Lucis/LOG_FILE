// =============================================================================
// Topic: 8. React Hooks
// Question 3: useState: Counter
// Question: Increment/decrement a counter using useState.
// =============================================================================

import { useState } from "react";

function HooksCounterUseState() {
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

export default HooksCounterUseState;