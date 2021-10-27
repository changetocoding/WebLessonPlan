# Lesson
Interacting with DOM
# Prior Homework assessment

# Lesson objectives
- Understand how to interact with DOM using JS


# Lesson time to deliever:
Unknown...

# Teacher instruction 


# Course materials

# DOM
With the HTML DOM, JavaScript can access and change all the elements of an HTML document.  
When a web page is loaded, the browser creates a Document Object Model of the page.  

## Illustration
- Date/time display on HTML using JavaScript with a refresh/timeout property
```html
<body onload="dateDisplay()">

    <h1 id="displaydateid"></h1>

</body>
```

```js
function dateRefresh(){
    let refresh = 1000; // Refresh rate in milli seconds
    let mytimeout = setTimeout('dateDisplay()', refresh)
}
        
function dateDisplay() {
    let datevariable = new Date()
    document.getElementById('displaydateid').innerHTML = datevariable
    dateRefresh();
}
```

- Dynamically changing html body element behaviour using JavaScript
- Redirect to a Webpage using JavaScript

```js
window.location.href = "nameOfPage.extension";
```

- Html element visibility based on a selection using JavaScript (Dependent Drop down using JavaScript)
```html
<body>
    <div>
        <p>Have you written Jamb?</p>
        <select name="" id="jambstatus" onchange="showOrHide();">
            <option></option>
            <option value="Yes">Yes</option>
            <option value="No">No</option>
        </select>
        <div id="jambscore">
            <p>What was your score?</p>
            <input type="number" placeholder="Enter Jamb score">
        </div>
    </div>
</body>
```
```js
document.getElementById("jambscore").style.display ='none';
    
function showOrHide(){
    let jambstatus = document.getElementById("jambstatus").value;
    
    if(jambstatus === "Yes"){
        document.getElementById("jambscore").style.display ='block';
    }else {
        document.getElementById("jambscore").style.display ='none';
    }
}
```
### Class Work
Display Nigerian states or America states based on the country selected - either Nigeria or America  
