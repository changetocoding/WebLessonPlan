# Lesson

# Prior Homework assessment

# Lesson objectives
- Understand difference between get and post.
- Use postman to make/test network requests


# Lesson time to deliever:
Unknown...

# Teacher instruction 

**Pop quiz: let vs var vs const**

## AJAX/Promises
JS is single threaded. Designed to be just minor interactivty on website. Multi threading added much later.

So ppl invented AJAX/Promises to get around the problem.

Imagine you want tea. You go to the kitchen you start the kettle. Now you have to wait for it to finish. In JS you would not do anything else while you wait.

AJAX behaves more like a human. As soon as you start the kettle (the aysnc request). You can now do something else like check your phone. As soon as the kettle finishes it makes a noise (The interrupt). You stop what you are doing, finish making the tea (Executing the promise), then can go back to whatever you are doing

Promise: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Using_promises  
A Promise is an object representing the eventual completion or failure of an asynchronous operation.


In English it means something you can attach a function to execute once it completes

```js
axios.get('/api/PhoneBook/getAll')   // Your promise object
            .then(...)  // Instructing the promise object to call the function in the brackets once it completes successfully
            .fail(...);  // Instructing the promise object to call the function in the brackets if it fails
```

You can also create your own promises but won't cover.

key bit do something. Once you have done it, do something else


# Course materials
Additional course materials that teachers should review and can be used
- Material 1


# Recommendations
- Additional notes



# Homework:
- Play around with CSS, Html, and bootstrap to create some wierd and whacky User interfaces


