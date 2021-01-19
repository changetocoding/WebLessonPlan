# Lesson
Talking to servers part 2 - Forms

# Prior Homework assessment


# Lesson objectives
- Understand Ajax
- Understand difference between GET and Post
- Understand forms


# Lesson time to deliever:
Unknown...

# Teacher instruction 

## Form
When Html was invented. Forms were the way to go. It was a way of submiting data. And you think of the internet as a whole it is all about submitting data.

https://developer.mozilla.org/en-US/docs/Learn/Forms/Sending_and_retrieving_form_data

Nice diagram about client/server architectures on that page too

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

**Confession: I have never done it this way and no one does it this way**

## AJAX
AJAX & Jquery to the rescue:
```js
$("#idForm").submit(function(e) {
    e.preventDefault(); // avoid to execute the actual submit of the form.

    var form = $(this);
    var url = form.attr('action'); // or plug in your url here
    
    // this bit can be swapped out with axios below
    $.ajax({
           type: "POST",
           url: url,
           data: form.serialize(), // serializes the form's elements.
           success: function(data)
           {
               alert(data); // show response from the server
           }
         });
});
```

Or with axios and Javasript's form data (newer way of doing it)
```js
var form = document.querySelector('form');
var data = new FormData(form);
axios.post('/example', data);
```
Even better: With modern ui frameworks you have a ViewModel object that contains the data the user has entered. So can directly just make a server call without having to find the elements and the data in the element first.



# Course materials
Additional course materials that teachers should review and can be used
- Material 1


# Recommendations
- Additional notes


# Homework
- We've set up an api server for you. Get your ecommerce website to talk to that api to get products and post orders.



