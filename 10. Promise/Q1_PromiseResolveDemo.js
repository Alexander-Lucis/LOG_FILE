// =============================================================================
// Topic: 10. Promise
// Question 1: Illustrate Promise and Resolve
// Question: Write JavaScript to illustrate Promise and resolve.
// =============================================================================

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