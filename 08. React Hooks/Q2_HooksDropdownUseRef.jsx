// =============================================================================
// Topic: 8. React Hooks
// Question 2: useRef: Dropdown Menu
// Question: Show and hide a dropdown menu using useRef.
// =============================================================================

import { useRef } from "react";
import "./ReactDropdownUseRef.css";

function ReactDropdownUseRef() {
  const menuRef = useRef();

  const showMenu = () => {
    if (menuRef.current.style.display === "none") {
      menuRef.current.style.display = "block";
    } else {
      menuRef.current.style.display = "none";
    }
  };

  return (
    <div className="container">
      <h2>Simple Drop Down Menu</h2>
      <button onClick={showMenu}>Menu</button>
      <div ref={menuRef} className="dropdown">
        <p>Home</p>
        <p>About</p>
        <p>Services</p>
        <p>Contact</p>
      </div>
    </div>
  );
}

export default ReactDropdownUseRef;

/*
ReactDropdownUseRef.css:

.container {
  text-align: center;
  margin-top: 100px;
}

button {
  padding: 10px 30px;
  font-size: 16px;
  cursor: pointer;
}

.dropdown {
  display: none;
  width: 200px;
  margin: 10px auto;
  border: 1px solid gray;
  background-color: white;
}

.dropdown p {
  padding: 10px;
  margin: 0;
  cursor: pointer;
}

.dropdown p:hover {
  background-color: lightgray;
}
*/