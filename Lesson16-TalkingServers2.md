# Lesson
Talking to servers part 2 - Forms

# Prior Homework assessment


# Lesson objectives
- Understand difference between GET and Post
- Understand forms


# Lesson time to deliever:
Unknown...

# Teacher instruction 

## Form
When Html was invented. Forms were the way to go. It was a way of submiting data. And you think of the internet as a whole it is all about submitting data.

https://developer.mozilla.org/en-US/docs/Learn/Forms/Sending_and_retrieving_form_data

Nice diagram about client/server architectures on that page too.

Most forms are post request.
What is difference between POST & GET

Answer (see lesson 14, "talking to servers I" too):
- Post tends to be updating data. No query parameters
- GET tends to be to fetch data.

So Forms naturally tend to be post requests. But can also have get request

## Form tag
Similar to Div: This is a set of input fields we are going to send to server

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
    <button>Send my greetings</button>
  </div>
</form>
```

It uses name to map the field to value. NOT ID

We've been creating forms with bootstrap
https://getbootstrap.com/docs/5.0/forms/overview/

It's why that page is called "Forms"

Youtube video: https://www.youtube.com/watch?v=E5MEzC0prd4

Explain why forms.

**Confession: I have never done it this way and don't know anyone that one does it this way**
(Emmanuel ask Jacob ask Mitul about it)

## Form Data

Or with axios and Javasript's form data (newer way of doing it)
```html
<form>
  <div>
    <label for="say">What greeting do you want to say?</label>
    <input name="say" id="say" value="Hi">
  </div>
  <div>
    <label for="to">Who do you want to say it to?</label>
    <input name="to" id="to" value="Mom">
  </div>
  <div>
    <button>Send my greetings</button>
  </div>
</form>
```
```js
let form = document.querySelector('form');
let data = new FormData(form);
axios.post('/example', data);
```


More on form data: https://developer.mozilla.org/en-US/docs/Web/API/FormData/Using_FormData_Objects

You can also do it with jquerys ajax but as people are moving away from ajax we will not cover that.

Even better: With modern js frameworks (like angular, react, vue) you have a ViewModel object that contains the data the user has entered. So can directly just make a server call without having to find the elements and the data in the element first.


## Quick and dirty way to do it
You can also just get the value of the field(s) and use it in the post or get request.
```html
<form>
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



# Course materials
Additional course materials that teachers should review and can be used


# Recommendations
- Additional notes


# Homework
- We've set up an api server for you. Get your ecommerce website to talk to that api to get products and post orders.
- Read: https://en.wikipedia.org/wiki/Representational_state_transfer


