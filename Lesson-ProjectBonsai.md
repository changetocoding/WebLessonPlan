# Bonsai Project





# Video on populating items and using the URL to compose things
This video example covers:

## Adding data to url parameter for page 
```
http://localhost:8099/test/second?name=Tom&age=10
```
In above request, it is a get request so we can add data to the url _'name=Tom&age=10'_  
The data is name:"Tom", age:10


### How use data in url to pass information to another page
For example you may want to do this: When a user clicks on a product, we go to the products detail page and display data for product. 
*But do not want to have to create a page for each a product (>10 pages!)*

What we can do instead:
1. On product list page we redirect on a product button click
```js
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

2. On the *product.html* page we need to get the query string from our url  
In the js page for it:
```js
// our url is .../product.html?id=1

let searchParams = new URLSearchParams(window.location.search)
// searchParams.has('id') // We can do this to check if param exists
let param = searchParams.get('id') // "1"

// We can now fetch the data with id 1 from the server using the fetch api or axios
```



### using js to automatically insert html 
Note this is advanced: You can just copy and paste the html for a few products and use js to set the link to the product details page, the  name and the price. Instead of using js to create the elements


```js
// 1. Use document.createElement to create your new element
let newDiv = document.createElement('div')
// 2. You can use inner html too. Not as recommended
newDiv.innerHTML = "<p style='font-size:32px;'>My Test text</p>"
// 3. Now attach the html element where you want
document.body.appendChild(newDiv);
```

We could instead find an element and add it as a child to that
```js
document.getElementById('generate-here').appendChild(newDiv);
```
Or use innerHTML (Not as recommende)
```js
let generateHere = document.getElementById("generate-here");
generateHere.innerHTML = '<div class="someclass"><a href="www.example.com"><p>some text</p></a></div>';
```

