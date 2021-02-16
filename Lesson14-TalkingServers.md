# Lesson
Cover promises first!!!
And aync await first!!!


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

Demonstrate a get and a post request

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


Demonstrate a get and a post request. Show or get students to compare how much easier doing a post request is with axios

### Http status codes
https://httpstatusdogs.com/
Explain HTTP Status codes get from making a request. 

The 3 important ones are: 
200 - Success  
401 - Forbidden
404 - not found  
500 - internal server error  


Demonstrate this in the network tab of chrome and look up what some of the codes you see there mean





### Difference between post and get request
Get them to research it and then present back to class and discuss
Start off here then: https://stackoverflow.com/questions/3477333/what-is-the-difference-between-post-and-get

**Answer:**

Get  | Post
--- | --- 
/api/it?name=Tom&no=10|/api/it |
Data is contained in Url| Data is contained in req body

Note all html urls you type into a browser e.g. www.bbc.co.uk are get requests.


### Advanced: How to get data from url and use it.
Scenario product page. Click on a product go to that products page and display data for product. But do not want a page per a product


On product list page redirect on a product button click
```js
//
productOneBtnElement.onclick = function(e){
   let newUrl = "/product.html?id=1"
   document.location.href = newUrl;
}
```
or just using an a link
```html
<a href="/product.html?id=1">More info</a>
```
Notice our use of html query string *?id=1*. [More info on query string](https://en.wikipedia.org/wiki/Query_string)

On the *product.html* page we need to get the query string from our url
```js
// our url is .../product.html?id=1

let searchParams = new URLSearchParams(window.location.search)
// searchParams.has('id') // We can do this to check if param exists
let param = searchParams.get('id') // "1"

// We can now fetch the data with id 1 from the server (or a local array)
```


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
- Research the difference between Post and get and present back to class

(Optional) Watch this for some gotcha's for Js [link](https://www.youtube.com/watch?v=hQVTIJBZook). It is from 2009 so it is a bit outdated
