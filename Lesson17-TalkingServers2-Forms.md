# Lesson
Talking to servers part 2 - Forms & Sending User input to server

# Prior Homework assessment


# Lesson objectives
- Understand difference between GET and Post Requests
- Understand forms
- Understand at least 2 different ways to send user input from Client to Server  (e.g. using a html Form and no js, form + formdata, post request with data)
- Understand why should not use GET to update data on server (Use Post instead)


# Lesson time to deliever:
Unknown...

# Teacher instruction 

We want to send user inpu to a server. We're going to show several 

## Quick and dirty way to do it
You can also just get the value of the field(s) and use it in the post or get request.
```html
<form>
  <div>
    <label for="say">What greeting do you want to say?</label>
    <input id="say" value="Hi">
  </div>
  <div>
    <label for="to">Who do you want to say it to?</label>
    <input id="to" value="Mom">
  </div>
</form>

<!-- Button somewhere else. Doesnt need to be within form -->
  <div>
    <button id = "btnSub" >Send my greetings</button>
  </div>
```
```js
document.getElementById("btnSub").onclick = function(e){
  e.preventDefault(); // Have to call this as default would be submit form (to nowhere) and reload page
  const sayTxt = document.getElementById("say").value; // Get value from input
  const toTxt = document.getElementById("to").value; // Get value from input
  const payload = {say:sayTxt, to:toTxt}; // 
  axios.post('https://example.com/example', payload); 
  // Fetch painful...
  //fetch('https://example.com/example', {
  //  method: 'POST', 
  //  headers: {
  //    'Content-Type': 'application/json',
  //  },
  //  body: JSON.stringify(payload),
  //})
}
```

## Form
When Html was invented. Forms were the way to send user input form client to server. It was a way of submiting data. And when you think of the internet as a whole it is all about submitting data.


IMPORTANT: https://developer.mozilla.org/en-US/docs/Learn/Forms/Sending_and_retrieving_form_data

_Nice diagram about client/server architectures on that page too._

Most forms are post request. 

_QUIZ: What is difference between POST & GET_

_Answer (see lesson 14, "talking to servers I" too):_
- _Post tends to be updating data. No query parameters_
- _GET tends to be to fetch data._
- **If you are updating data use POST as webcrawlers tend to look for get requests, so you don't want google accidentally updating your database when it automatically crawls the web.**

So Forms naturally tend to be post requests. But can also have get request.

IMPORTANT: Notice what happened to the page: It loaded a new page.


## Form tag
Similar to Div: Used to group a set of input fields we are going to send to server

We've been creating forms with bootstrap
https://getbootstrap.com/docs/5.0/forms/overview/

It's why that page is called "Forms"

## Html Form, No Javascript
```html
<form action="http://www.foo.com" method="GET">
   <!-- Method can be GET or POST depending on your server -->
  <div>
    <label for="say">What greeting do you want to say?</label>
    <input name="say" id="say" value="Hi">
  </div>
  <div>
    <label for="to">Who do you want to say it to?</label>
    <input name="to" id="to" value="Mom">
  </div>
  <div>
    <!-- Button needs to be within form -->
    <button>Send my greetings</button>
  </div>
</form>
```

It uses name to map the field to value. NOT ID


**Confession: I have never done it this way and don't know anyone that one does it this way**
(Emmanuel ask Jacob ask Mitul about it)

## Form Data
Or with axios and Javasript's FormData (newer way of doing it)
```html
<form id="myForm">
  <div>
    <label for="say">What greeting do you want to say?</label>
    <input name="say" id="say" value="Hi">
  </div>
  <div>
    <label for="to">Who do you want to say it to?</label>
    <input name="to" id="to" value="Mom">
  </div>
  <div>
    <button id="btnSub">Send my greetings</button>
  </div>
</form>
```
```js
// we handle the submit event on the form
document.getElementById("myForm").addEventListener("submit", function(e){
  let form = document.getElementById('myForm');
  let formData = new FormData(form);
  axios.post('/example', formData);
  
  e.preventDefault(); // Have to call this as default would be submit form (to nowhere) and reload page. This prevents that from happening. Try removing this and see how the url of the page changes
}
```
Video (Visual Learners): https://www.youtube.com/watch?v=c3qWHnJJbSY

More on form data: https://developer.mozilla.org/en-US/docs/Web/API/FormData/Using_FormData_Objects

## Viewing HTTP Request in chrome
[Emmanuel]

In chrome debug open network tab.  
Click on the request.  
Then click on the Headers sub tab.
scroll to bottom which will have data
https://stackoverflow.com/questions/15603561/how-can-i-debug-a-http-post-in-chrome  
![Debug](https://i.stack.imgur.com/8RVcY.png)

This also covers it https://developer.mozilla.org/en-US/docs/Learn/Forms/Sending_and_retrieving_form_data#viewing_http_requests


Show how it looks between 
### Get
All get request use a query string. So the url the data will be sent to will look like _.../api/save?say=Hi&to=Mom_
```
say=Hi&to=Mom
```
Decoded:
```
Query String Parameters (Decoded)
say: Hi
to: Mom
```

**GET requests are not recommend if it will update your data. So For example can use GET when searching for orders with a name and customer Id. But do not for updating data**

### Post form data
For POST if using Javascript's FormData then will send as below.
```
Form Data
say: Hi
to: Mom
```

### Post JSON
Otherwise will send as a JSON like below
```json
{"say": "Hoi", "to": "Peter"}
```



## Jquery/Modern JS frameworks
You can also do it with jquerys ajax but as people are moving away from ajax we will not cover that.

Even better: With modern js frameworks (like angular, react, vue) you have a ViewModel object that contains the data the user has entered. So can directly just make a server call without having to find the elements and the data in the element first.


## Pros and cons of each approach

### Just send over data
Pros:
- Don't need a form: more flexible

Cons:
- No logical grouping of the fields (e.g. like how div groups elements, form does the same for user input. Lose this benifit)

### Html form (no js)
Pros:
- No JS required

Cons:
- Loads a new page so server needs to return html

### Html form (with js)
Pros:
- Flexiblity over how send data over and validation of the user input

Cons:
- More code 


# Course materials
Additional course materials that teachers should review and can be used


# Recommendations
- Additional notes


# Homework
## Project (3 weeks)
We've set up an api server for you. Get your ecommerce website to talk to that api to get products and post orders.  
Url: https://tbhpwebdevapi.azurewebsites.net/api
Api Documentation & playground : https://tbhpwebdevapi.azurewebsites.net/swagger/index.html  
Example to get list of all products: https://tbhpwebdevapi.azurewebsites.net/api/Bonsai

We also have '.../usingXXX' methods for you to try out the different ways - Use a combination of them (e.g. POST order using FormData, while use POST with json to add a new client)

## Other Homework
- Read: https://developer.mozilla.org/en-US/docs/Learn/Forms/Sending_and_retrieving_form_data
- (Visual learners) Video: https://www.youtube.com/watch?v=c3qWHnJJbSY
- Optional Read: https://en.wikipedia.org/wiki/Representational_state_transfer
