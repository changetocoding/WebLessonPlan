# Lesson

# Prior Homework assessment

# Lesson objectives
- Make web request for data using Axios
- Make web request for data using fetch api
- Http status codes


# Lesson time to deliever:
Unknown...

# Teacher instruction

## Js Ajax requests
Hitting the server as I like to call it. 

Most modern web applications talk to a server to get data. (MUST DO:) Get students to come up with a few examples (e.g yahoo mail talks to server to get emails, google to get search results).

Tie back to 

We'll explain AJAX (the underlying technology) & difference between get and post later. For the time being just need to know how to make a request.

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
https://classroom.udacity.com/courses/ud109/lessons/ (chapter 3)

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


### Difference between post and get request
Get them to research it and then present back to class and discuss
Start off here then: https://stackoverflow.com/questions/3477333/what-is-the-difference-between-post-and-get

**Answer:**

Get  | Post
--- | --- 
/api/it?name=Tom&no=10|/api/it |
Data is contained in Url| Data is contained in req body


# Course materials
Additional course materials that teachers should review and can be used
- https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch
- https://javascript.info/fetch
- https://github.com/axios/axios
- https://jsonplaceholder.typicode.com/
- https://httpstatusdogs.com/

# Recommendations
- It's really good to have elements on the page which you update with the value from the request.
- Make lesson interactive by testing knowledge of arrow vs Function Declaration, vs function expressions. E.g.

```js
axios.get("url").then(function (response) {
   console.log(response.data);
   ...
});

// so how would you rewrite the function in the then so that is is an arrow function
axios.get("url").then((response) => {
   console.log(response.data);
});
```

# Homework
- https://classroom.udacity.com/courses/ud109/lessons/ (chapter 3)
- Carry on with project. In 2 weeks will come back to this and make server requests
- Present difference between Post and get

(Optional) Watch this for some gotcha's for Js [link](https://www.youtube.com/watch?v=hQVTIJBZook). It is from 2009 so it is a bit outdated
