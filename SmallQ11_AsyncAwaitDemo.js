// Question: Create a javascript to illustrate the use of async and await.
// Run: node AsyncAwaitDemo.js

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
