// =============================================================================
// Topic: 9. Async/Await
// Question 1: Illustrate Async and Await
// Question: Write JavaScript to illustrate async and await.
// =============================================================================

async function displayMessage() {
  console.log("Start");
  await new Promise((resolve) => {
    setTimeout(() => {
      console.log("Hello, this is Async/Await example");
      resolve();
    }, 2000);
  });
  console.log("End");
}

displayMessage();