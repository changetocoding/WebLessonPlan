# Lesson

# Prior Homework assessment

# Lesson objectives
- Understand how to manipulate the dom using Jquery and the javascript dom library.


# Lesson time to deliever:
Unknown...

# Teacher instruction 
- Cover content in slide deck by emmanuel

Key points to cover:
- Document ready: Demonstrate by example of html with script tags in head and doesn't change text because html reads top to bottom so reads & executes script first and the element does not exist,  
Then with document ready: The text will change as waits for page to fully load  
Also mention if move script to bottom without document ready will work. Test they understand why
```html
<!DOCTYPE html>
<html lang="en">
<head>
  <link rel="stylesheet" href="/lib/bootstrap/dist/css/bootstrap.min.css" />
  <script src="/lib/jquery/dist/jquery.min.js"></script>
  <script src="/js/test.js"></script>
</head>
<body>
  <main>
      <div class="container text-center">
        <input id="init" />
        <button id="btnInit" class="btn btn-primary">Save!</button>
        <h2 id="elm" class="alt-title">Our <span>Volunteers</span></h2>
      </div>
  </main>
</body>
</html>
```
```js
// uncomment below to show ready function
// $(document).ready(function () {
  $("#elm").text("Test");
// });
```


Show fetching text from input and displaying it in a label (same html file as above)
```js
document.addEventListener("DOMContentLoaded", function(){
  $("#btnInit").on("click", function(){
    var text = $("#init").val();
    $(".alt-title").text(text);

  });
});
```

# Course materials
Additional course materials that can be used
- Slide deck by emmanuel


# Recommendations
- It is really good to contrast how to do things in jquery vs the js dom library.
- Make sure it is clear that the js dom library is the preferred way of doing things (jQuery was to fill in the gaps in the dom library in 2006. Those gaps have been filled now)
- 

# Homework
- Play around with jquery and js dom library around those
- Further reading?

