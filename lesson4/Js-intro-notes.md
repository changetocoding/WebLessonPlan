# Javascript

## A history lesson
JavaScript(JS) is the most popular language in the world. It also has the most interesting programming language history. Maybe we can pitch as a Netflixs documentary? 
- C# has most boring history. Basically just copied Java
- Python named after monthy python (gotta have a sense of humour)

![Js timeline](https://miro.medium.com/max/1000/1*f6g--taiqSYTIJY5WUx7tw.jpeg)
### 1995 - Origins
JavaScript. Created by Netscape. Biggest brower at that point in time. 1990s
- Created in weeks
- Named JavaScript to "borrow" popularity of Java (Marketting departments eh...)
![Js Confused with Java](/Javascript/Week20_Intro.Js/jswiki.JPG)

Design principles:
- Scripting language
- Designed to add a *little* bit of interactivity to webpage
- Java like syntax (C# copied this too...)
- Functions as First-Class Objects
- Prototype based object model


### 1996/7 - ECMAScript: JavaScript as a standard
ECMA is a standards body. JS created as a standard, named ECMAScript.
Rumour is when MS joined committee catgorised every bug in JS and ensured remained. They had thier rival version JScript
V1-3 released 1997-1999

### 1999-2010 - The dead years
Not updated. The ECMA committee had a spat. MS, yahoo vs rest over how simple next version should be.
1st Browser wars. IE got 95% market share, then safri, firefox released.

Complex version of ES4 scraped. Simple version released as ES5 in 2011

### AJAX
Async Javascript: series of techniques to make JS react with servers serving data. Will discuss in more depth over JS course
Open source communities for the win: jQuery, Protoype.

### A modern programming language
Why Js won. Flash, JScript big competition. No changes in JS during a very tumulus period. Stability won out.

Then alot of ES4 rebirthed as ES6/ES2015 in 2015

### Node.JS 
Serverside JS (Why do I need to hire server side developers when I can just use my front end developers...)

### ModernJS frameworks Angular, React, Vue.Js
Polyfilling JS to make it full fledged
- Initially started off as reactive pages using MVVM (A Design pattern To discuss later) 


# JS 101
I use this for JS reference https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference

## Basics
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
