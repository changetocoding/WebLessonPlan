# Lesson

# Prior Homework assessment

# Lesson objectives
- Make web request for data using Axios
- Make web request for data using fetch api
- Understand difference between GET and POST request


# Lesson time to deliever:
Unknown...

# Teacher instruction 

# Js Ajax requests
Hitting the server as I like to call it. 

Most modern web applications talk to a server to get data. Get students to come up with a few examples (e.g yahoo mail talks to server to get emails, google to get search results).

We'll explain AJAX (the underlying technology) later. For the time being just need to know how to make a request.

Make sure students know can use to get data, but also update data on server.

## Server request
Use this website to test api calls: https://jsonplaceholder.typicode.com/

### Fetch api
JS built in api for doing ajax requests
```js
fetch('/api/search/forecast?day=saturday')
   .then(response => response.json())
   .then(data => console.log(data));

```
Additional resources:
https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch
https://javascript.info/fetch

### Axios
https://github.com/axios/axios
popular libray for doing ajax requests

```js
axios.get('/api/search/forecast?day=today')
    .then(function (response) {
        debugger;
        console.log(response.data);
    })
    .catch(function (error) {
        // handle error
        console.log(error);
    });
    
    
axios.post('/api/search/update', { day: "Today", weather: "Sunny"})
    .then(function (response) {
        debugger;
        console.log(response.data);
    })
    .catch(function (error) {
        // handle error
        console.log(error);
    });
```

### Http status codes
https://httpstatusdogs.com/
Explain HTTP Status codes get from making a request. The 3 important ones are: 200 - Success, 404- not found, and 500 internal server error

# Course materials
Additional course materials that teachers should review and can be used
- https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch
- https://javascript.info/fetch
- https://github.com/axios/axios
- https://jsonplaceholder.typicode.com/
- https://httpstatusdogs.com/

# Recommendations
- Additional notes


# Homework
- Carry on with project. In 2 weeks will come back to this and make server requests

(Optional) Watch this for some gotcha's for Js [link](https://www.youtube.com/watch?v=hQVTIJBZook). It is from 2009 so it is a bit outdated
