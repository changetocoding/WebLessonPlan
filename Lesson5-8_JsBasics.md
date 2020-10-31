#  Javascript basics
Four (4) lessons

# Prior Homework assessment

# Lesson objectives
- Understand basic javascript syntax
- Understand variables and objects
- Understand functions
- Understand how to use the browser console


# Lesson time to deliever:
Four (4) lessons

# Teacher instruction 
Create a lesson plan from the course materials below and around basic javascript information

Cover opening the browser debugger by pressing F12. Chrome is recommended browser as it is the easiest for debugging.

Then execute the js code in the browser console so students get used to it. But also switch to html file + js file so don't forget that.
Go through basics (see below: Arrays, objects, selection, for loops) and explain difference between let and var, and == vs ===
Then cover functions in javascript

Cover the help documentation:
Stackoverflow
I use this for JS reference https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference

Also cover code pen see below:


# Course materials
- https://javascript.info/ - Chpt 2: JS fundamentals
- https://developer.mozilla.org/en-US/docs/Learn/Getting_started_with_the_web/JavaScript_basics

## Code pen
https://codepen.io/  
My favourite html/js playground. Tons of work people have done

### JS Basics:
Open browser. Press F12. Now have developer console. Can run js code
```js
// Set a variable
var a = "Hello World";  // Strings can be '' or "". Pick one and stick to it for your code
console.log(a); // Note console almost always there (but not always)

// Create an object
var it = { a: 20, b: "Test" }
console.log(it.a)

// semi-colons (;) are optional. Js will automatically fill for you

// this is also a dictionary
console.log(it["a"])

// Arrays
var myArr = ['a', 'b', 'c'];

// This is equivalent to a list in C#
console.log(myArr[0]);   // 'a'
myArr.push(10) // Not typed, so can add anything
myArr[2] = "Testing the world";
console.log(myArr);


// Selection
let b = 10
if(a === 2){
  // will discuss == vs === in a sec
  console.log("b is 2");
} else if(b > 0) {
  console.log("b Positive");
} else {
  console.log("b is negative");
}

// For loop
let str = '';
for (let i = 0; i < 9; i++) {
  str = str + i;
}

console.log(str);

// Can do a For each on an array
var array1 = ['a', 'b', 'c'];

array1.forEach(function(x){ console.log(x)});

// new ES2015 way with function shorthand
array1.forEach(element => console.log(element));

```

### == Vs ===
https://stackoverflow.com/questions/359494/which-equals-operator-vs-should-be-used-in-javascript-comparisons
```js
"0" == 0; // True
"0" === 0; // False

// Quirk of js
"abc" == new String("abc")       // true
"abc" === new String("abc")      // false
// because ...
typeof "hello world"             // "string"
typeof new String('hello world') // "object"
```

As a general rule always use === and never ==


### let vs var vs const
If don't use a keyword, variable is declared on Global scope. Aka global variable. Bad!

"var" original way of declaring a variable

"let" is new way. Difference is around how they behave within scopes. E.g. a for loop. If you have programmed before "let" behaves the way you are used to. "var" is different

"const" - Constant. Value is not allowed to change (aka be set again)


```
let a = 10;
var b = 10;
const c = 10;

// Let variable is not visible outside of the loop
for(let i = 0; i <10; i++){
  // ...
}
console.log(i); // undefined

// But var variable is
for(var j = 0; j <10; i++){
  // ...
}
console.log(j); // 10

```
## No strong types in javascript
```js
var mycar = {
  brand: "Honda",
  model: "Accord",
  year: 1998
};
```

## Functions
```js
function myFunc(theObject) {
  theObject.brand = "Toyota";
}

/* Pass object reference to the function */
myFunc(mycar);

// other way to define a function
var myFunction = function() {
  theObject.brand = "BMW";
}

// or with this way. In stack traces when error get a better error message (but no one does this way)
var myFunction = function namedFunction(){
    statements
}

myFunction(mycar);
```
### Arrow functions
The arrow function expression (=>). Very similar to C#
```js
(t) => { console.log(t); }
```

### Self invoking functions
```js
(function() {
    statements
})();
```
The function invokes as soon as the script is loaded. See it alot in jquery
```js
$(function () {
  // code to run once all view elements are initialised
})();
```

### Function hoisting
Scripted but functions get read first so can call them from anywhere in script

### Q&A
What happens if I pass in more parameters to a function than it has slots?  
What happens if I pass in less?  


# Recommendations
- Nothing


# Homework
- Lessons 5-7: Udacity course  https://classroom.udacity.com/courses/ud803 
- Lesson 8: Snake (see below)

### Homework: Snake
https://codepen.io/arkev/pen/pDdoL?editors=0010  
https://www.studytonight.com/post/snake-game-in-html-and-javascript  
https://www.codeexplained.org/2018/08/create-snake-game-using-javascript.html  

I want you to create a snake game in visual studio. Those guides can help you out. If you can add some additional cool features (so I know you didn't just copy and paste!!! :D)

