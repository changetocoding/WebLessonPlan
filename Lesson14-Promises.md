# Lesson

# Prior Homework assessment

# Lesson objectives
- Understand Promises in Javascript
- May be better to do this lesson as student studies this course & then come back and present/explain the concept. And explain in relation to fetch api and axios api have been using:
https://classroom.udacity.com/courses/ud898



# Lesson time to deliever:
Unknown...

# Teacher instruction 

- Explain everytime thenthat is a promise
- Explain how out of order resolved
```js
let trees;
fetch('http://example.com/movies.json') //  first  0sec
.then(response => response.json())  //third  5sec
.then(data => trees = data) // fourth  65sec
.catch(err => console.log(err)); 

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
