# Lesson

# Prior Homework assessment

# Lesson objectives
- Understand Promises in Javascript
- We'll need a working understanding of this in order to do talking to servers.


# Lesson time to deliever:
Unknown...

# Teacher instruction 

- Explain everytime see then that is a promise
- Explain how out of order resolved
```js
let trees;
fetch('http://example.com/movies.json') //  first  0sec
  .then(response => response.json())  //third  5sec
  .then(data => trees = data) // fourth  5sec
  .catch(err => console.log(err)); // only if something goes wrong on fetch, or first then (second then maybe too. check?)

// update element happens before trees is set to the data
Element.val(trees);// second   1sec
```
- Explain promise chaining
```js
axios
  .get('https://maps.googleapis.com/maps/api/geocode/json?&address=' + this.props.p1)
  .then(response => {
    this.setState({ p1Location: response.data });
    return axios.get('https://maps.googleapis.com/maps/api/geocode/json?&address=' + this.props.p2);
  })
  .then(response => {
    this.setState({ p2Location: response.data });
    return axios.get('https://maps.googleapis.com/maps/api/geocode/json?&address=' + this.props.p3);
  })
  .then(response => {
    this.setState({ p3Location: response.data });
  }).catch(error => console.log(error.response));
```

-Explain homework goes through what happens behind the scenes and how to create your own Promises. Useful to know but never needed to do it myself


# Course materials
Additional course materials that teachers should review and can be used
- Material 1


# Recommendations
- Additional notes


# Homework
- https://classroom.udacity.com/courses/ud898 (lesson 1)
