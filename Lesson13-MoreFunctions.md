

# Lesson

# Prior Homework assessment

# Lesson objectives
- Function declarations vs function expressions
- Arrow functions
- Self invoking functions
- Function hoisting function declarions


# Lesson time to deliever:
Unknown...

# Teacher instruction 
We'll be covering some things they already know. So as much as possible ask them if they already know it and if they do get them to explain:

- E.g. What are two ways to write function (don't care about names, want code), get them to come up and write the code.
- Then tell them the names of the two ways
- Then ask them the difference between 2
- Then describe the difference. 
- Then reinforce using the infographic
- Tie it all together 

Explain why call back functions really important: Show examples in js e.g. map, foreach ...


# Course materials
Lesson Plan: https://github.com/emarkexe2001/Web-Development-Course/blob/main/Week%20Nine/README.md

Tying it all together
```
function forEach(arr, fn){
  for(let i =0; i<arr.length; i++){
    fn(arr[i]);
  }
}

```

Additional course materials that teachers should review and can be used
- Infographic on lesson plan
- https://javascript.info/function-expressions - For function expressions
- https://javascript.info/arrow-functions-basics - For arrow functions
- https://stackoverflow.com/questions/336859/var-functionname-function-vs-function-functionname

# Recommendations
- Additional notes


# Homework
- You will create some very useful js libary funtions: We've done foreach for you
- filter
```js
// Your code
var youngsters = filterIt(peopleArrary, function (item) {
	return item.age < 30;
});

// Must match
var expected = peopleArray.filter(function (item) {
	return item.age < 30;
});
```
- map
```js
// Your code
var names = mapIt(peopleArray, (item) => return item.name);

// Must match
const expected = peopleArray.map((item) => return item.name; );
```

- some
```js
// Your code
var names = hasSome(peopleArray, (item) => return item.age < 30);

// Must match

var anyUnder30 = peopleArray.some(function (item) {
	return  item.age < 30;
});
```


