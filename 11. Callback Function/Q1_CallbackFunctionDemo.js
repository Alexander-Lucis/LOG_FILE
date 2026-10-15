// =============================================================================
// Topic: 11. Callback Function
// Question 1: Illustrate a Callback Function
// Question: Create a JavaScript application to illustrate callback functions.
// =============================================================================

function calculate(a, b, callback) {
  const result = a + b;
  callback(result);
}

function display(result) {
  console.log("Addition = " + result);
}

calculate(10, 20, display);