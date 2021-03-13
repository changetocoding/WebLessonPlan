# Lesson

# Prior Homework assessment

# Lesson objectives
- Understand how async/await keyword makes working with promises much more simpler and straight forward with js.
- Demonstrate converting from using .then/.catch to using async await


# Lesson time to deliever:
Unknown...


# Teacher instruction 
Build your lesson plan from these three resources:
- https://dev.to/lydiahallie/javascript-visualized-promises-async-await-5gke
- https://javascript.info/async-await
- https://www.freecodecamp.org/news/learn-promise-async-await-in-20-minutes/

## What is Async?

Async is a keyword that allows us to return a promise - for example if we place the async keyword before a function, the function will return a promise. Async is a much cleaner and easier way of writing a promise. An async function will always return a promise.
```js
async function returnNumber()
{
  return 5;
}

returnNumber().then(console.log);
```
We can also write an async function like this
```js
const returnNumber = async () => {
  return 5
}
```

## Await

Await can be used inside of an async function to wait for a promise to resolve before performing an action once the promise has resolved. The key bit about the Await keyword is that it can only be used inside of an async function

```js
async function getDataFromAPI()
{ 
  data = await fetch('http://example.com/movies.json') 
}
```

This will not work because the await keyword can only be used inside an async function.
```js
function getDataFromAPI()
{
  data = await fetch('http://example.com/movies.json') 
};
```

## Converting from .then to aync
We have this function using .then() and a callback. We can rewrite as an async functions
```js
// callback is the function to call on success
function getAnswer(id, callBack){
   axios.get(`/api/auth/`)
    .then(function(hasPermission){
      if(hasPermission){
        return axios.get(`/api/answer/${id}`).then(answer => callBack(answer))
      }else{
        return callBack("You don't have permision to view the answer");
      }
    })
}

function logAnswer(){
  const id = 1;
  getAnswer(id, answer => {
    console.log("The answer to question 1 is: ", reanswers)
  })
}
```

Firstly we can rewrite getAnswer as an async function
```js
async function getAnswer(id){
  const hasPermission = await axios.get(`/api/auth/`);
  if(hasPermission){
    const answer = await axios.get(`/api/answer/${id}`)
    return answer;
  }else{
    return "You don't have permision to view the answer"
  } 
}

function logAnswer(){
  const id = 1;
  getAnswer(id).then(function(answer){
    console.log(answer)
  })
}
``` 

We can also rewrite logAnswer() as an async function
```js
async function getAnswer(id){
  const hasPermission = await axios.get(`/api/auth/`);
  if(hasPermission){
    const answer = await axios.get(`/api/answer/${id}`)
    return answer;
  }else{
    return "You don't have permision to view the answer"
  } 
}

// the log answer can be async too 
async function logAnswerAsync(){
  const id = 1;
  const answer = await getAnswer(id);
  console.log("The answer to question 1 is: ", answer)
}
```


Finally when the function has a .catch() this is how to rewrite
```js
function getAnswer(id){
   axios.get(`/api/answer/${id}`)
    .then(function(data){
      // do something with data
    })
    .catch(function(err){
      // we just log the error here, but normally should properly handle the error
      console.log(err)
    })
}
```
We can rewrite as an async function using try/catch
```js
async function getAnswer(id){
  try {
    const data = await axios.get(`/api/answer/${id}`)
    // do something with data
  } catch (error) {
    // Equivalent to the .catch()
    // we just log the error here, but normally should properly handle the error
    console.log(err)
  }
}
```

# Recommendations
- Additional notes


# Homework
- Read: https://dev.to/lydiahallie/javascript-visualized-promises-async-await-5gke
- Read: https://javascript.info/async-await and do tasks from it
- Read: https://www.freecodecamp.org/news/learn-promise-async-await-in-20-minutes/ and do tasks from it
