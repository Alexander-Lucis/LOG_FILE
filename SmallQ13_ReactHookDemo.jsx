// Question: Create any react component to illustrate the react hook.
import { useState, useEffect } from "react";

function ReactHookDemo() {
  const [count, setCount] = useState(0);
  const [name, setName] = useState("Ujwala");

  useEffect(() => {
    document.title = `Count: ${count}`;
    console.log("Count changed:", count);
  }, [count]);

  return (
    <div>
      <h1>React Hook Demo</h1>
      <h2>Hello, {name}</h2>
      <input
        type="text"
        value={name}
        onChange={(e) => setName(e.target.value)}
      />
      <h3>Count: {count}</h3>
      <button onClick={() => setCount(count + 1)}>Increase Count</button>
    </div>
  );
}

export default ReactHookDemo;
