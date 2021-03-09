# Lesson

# Prior Homework assessment

# Lesson objectives
- Understand Async
- Understand Promises in Javascript
- We'll need a working understanding of this in order to do talking to servers.


# Lesson time to deliever:
Unknown...

# Teacher instruction 




## AJAX/Promises
JS is single threaded. Designed to be just minor interactivty on website. Bad news is the page will just freeze up when getting data from server, and remember internet used to be very slow so could take seconds or even minutes...

So ppl invented AJAX (Asynchronous JavaScript)/Promises to get around the problem.

Imagine you want tea. You go to the kitchen you start the kettle. Now you have to wait for it to finish. In JS you would not be able do anything else while you wait.

AJAX behaves more like a human. As soon as you start the kettle (the aysnc request). You can now do something else like check your phone. As soon as the kettle finishes it makes a noise (The interrupt). You stop what you are doing, finish making the tea (Executing the promise), then can go back to whatever you are doing.

This is different from multi-threading/parrallelism. In the above example with Multi-threading you would have two people in the kitchen: One boiling the water, the other doing other stuff.

Another Explaination: https://stackoverflow.com/questions/34680985/what-is-the-difference-between-asynchronous-programming-and-multithreading.


## Promise 
### What is a promise

Promises are a way of handling asynchronous code, specifically for what happens after an asynchronous task is completed.

Promises can only be resolved once if there is more than one resolve in a promise only the first action in the promise will be resolved, the second action in the resolve will do nothing.

We use Promises when working with ajax requests or any async task that requires an action after it has been complete.

### Promise Components
A promise conists of three parts, the promise object usually connecting to an api route through a url, _.then()_ - what happens after the promise has been resolved, _.catch()_ - what happens if the promise is rejected.

Writing your own Promise code
```js
 new Promise(function(resolve, reject) {
 resolve('hi);
});
```
_Explain homework goes through what happens behind the scenes and how to create your own Promises. Useful to know but never needed to do it myself_

A promise can have 2 states 
- Resolve - the promise was resolved successfully
- Reject - the promise was rejected (something went wrong)

### .then() and .catch()
With the Promise object we can do a .then, which allows us to perform an action with the result when the promise is resolved. _.then()_ are asynchonous

```js
axios.get('https://example.com/api/PhoneBook/all')   // Your promise object
            .then(...)  // Instructing the promise object to call the function in the brackets once it completes successfully
            .catch(...);  // Instructing the promise object to call the function in the brackets if it fails
```
So in this example we are using axios to make a http request. This returns a promise object. 
The _.then()_ will be executed once data has been fetched from the server

.catch is used for recieving errors when a promise is rejected, allowing us to do something after the error happens e.g log the error or retry the request. 

### Async means code probably will get executed out of order
Imagine the network request takes 5 seconds. In that case:
```js
let trees;
fetch('http://example.com/movies.json') //  first  0sec
  .then(response => response.json())  //third  5sec
  .then(data => trees = data) // fourth  5sec
  .catch(err => console.log(err)); // only if something goes wrong on fetch, or first then (second then maybe too. check?)

// update element happens before trees is set to the data
Element.val(trees);// second   1sec
```

# Chaining promises
We can chain promises together, to have multiple results happen after a promise handler has been resolved. Chained promises are sequential so they happen one after another

In this case we make the calls one after each other to the google maps api. A more useful example would be getting some data then using it to make the next request
```js
axios
  .get('https://maps.googleapis.com/maps/api/geocode/json?&address=' + this.props.p1)
  .then(response => {
    this.setState({ p1Location: response.data });
    return axios.get('https://maps.googleapis.com/maps/api/geocode/json?&address=' + this.props.p2);
  })
  .then(response => {
    this.setState({ p2Location: response.data });
    return axios.get('https://maps.googleapis.com/maps/api/geocode/json?&address=' + this.props.p3);
  })
  .then(response => {
    this.setState({ p3Location: response.data });
  }).catch(error => console.log(error.response));
```


# Course materials
Additional course materials that teachers should review and can be used
- https://javascript.info/promise-basics
- https://javascript.info/callbacks
- https://javascript.info/promise-chaining


# Recommendations
## Additional notes:
- We'll be covering promises and AJAX over next few lessons so review this and the next 2 lessons and can adjust content. Also let students know that we'll slowly build on this.

# Homework
- https://classroom.udacity.com/courses/ud898 (lesson 1)


Additional help for setting up exoplanet explorer 

1. Open up git Bash and clone the repo using git clone https://github.com/udacity/exoplanet-explorer
2. Go to the folder using cd exoplanet-explorer and install gulp using npm install -g gulp bower
3. Install the polymer starter kit npm install && bower install -f polymer-starter-kit
4. Create a json file called npm-shrinkwrap.json and add the following line
Tutorial explaining npm-shrinkwrap.jspm : https://timonweb.com/javascript/how-to-fix-referenceerror-primordials-is-not-de
