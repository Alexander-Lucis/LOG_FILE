// Question: Create a javascript to illustrate the use of promise and resolve.
// Run: node PromiseResolveDemo.js

let myPromise = new Promise(function (resolve, reject) {
  let success = true;
  if (success) {
    resolve("Promise is resolved successfully!");
  } else {
    reject("Promise is rejected!");
  }
});

myPromise
  .then(function (result) {
    console.log(result);
  })
  .catch(function (error) {
    console.log(error);
  });
