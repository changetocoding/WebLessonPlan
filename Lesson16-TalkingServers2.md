# Lesson
Talking to servers part 2 - Forms

# Prior Homework assessment


# Lesson objectives
- Understand difference between GET and Post
- Understand forms
- Use a form to send data from Client to Server


# Lesson time to deliever:
Unknown...

# Teacher instruction 

## Form
When Html was invented. Forms were the way to go. It was a way of submiting data. And you think of the internet as a whole it is all about submitting data.

https://developer.mozilla.org/en-US/docs/Learn/Forms/Sending_and_retrieving_form_data

_Nice diagram about client/server architectures on that page too._

Most forms are post request. 

_QUIZ: What is difference between POST & GET_

_Answer (see lesson 14, "talking to servers I" too):_
- _Post tends to be updating data. No query parameters_
- _GET tends to be to fetch data._
- **If you are updating data use POST as webcrawlers tend to look for get requests, so you don't want google accidentally updating your database when it automatically crawls the web.**

So Forms naturally tend to be post requests. But can also have get request

## Form tag
Similar to Div: Used to group a set of input fields we are going to send to server

We've been creating forms with bootstrap
https://getbootstrap.com/docs/5.0/forms/overview/

It's why that page is called "Forms"

## Html Form, No Javascript
```html
<form action="http://www.foo.com" method="GET">
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

Or with axios and Javasript's form data (newer way of doing it)
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
  
  e.preventDefault(); // Have to call this as default would be submit form (to nowhere) and reload page
}
```
Video (Visual Learners): https://www.youtube.com/watch?v=c3qWHnJJbSY

More on form data: https://developer.mozilla.org/en-US/docs/Web/API/FormData/Using_FormData_Objects

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
### Get (can be form data or object)
url will look like https://tbhpwebdevapi.azurewebsites.net/api/Message/saveWithGet?say=Hi&to=Mom
```
Query String Parameters (Decoded)
say: Hi
to: Mom
```

### Post form data
```
Form Data
say: Hi
to: Mom
```

### Post JSON
```json
{say: "Hoi", to: "Peter"}
```



## Jquery/Modern JS frameworks
You can also do it with jquerys ajax but as people are moving away from ajax we will not cover that.

Even better: With modern js frameworks (like angular, react, vue) you have a ViewModel object that contains the data the user has entered. So can directly just make a server call without having to find the elements and the data in the element first.


# Course materials
Additional course materials that teachers should review and can be used


# Recommendations
- Additional notes


# Homework
- We've set up an api server for you. Get your ecommerce website to talk to that api to get products and post orders.  
Url:   
Api Documentation & playground : https://tbhpwebdevapi.azurewebsites.net/swagger/index.html  
Example to get list of all products: https://tbhpwebdevapi.azurewebsites.net/api/Bonsai
- Read: https://developer.mozilla.org/en-US/docs/Learn/Forms/Sending_and_retrieving_form_data
- (Visual learners) Video: https://www.youtube.com/watch?v=c3qWHnJJbSY
- Optional Read: https://en.wikipedia.org/wiki/Representational_state_transfer
