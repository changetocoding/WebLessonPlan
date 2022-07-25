# TESTING WITH JAVASCRIPT

## Packages
0. Make sure npm is setup in your project. Getting this to work without it will make you sad. Use this command in the root of your project if this is a fresh and/or npm-less project.
```
npm start
```
1. If you are testing on an existing project, navigate to it in command line using Git Bash (right click in the folder, select 'Git Bash here') or manually path to it yourself.
2. Install the packages needed to start testing. For this example, let's use Mocha and Chai as a development dependency (the save-dev option) since projects should not need tests to function properly and are only used to aid in development.
```
npm install --save-dev mocha
and
npm install --save-dev chai
```

## Setting up tests
Before we can start testing, we'll need to create and designate files to be used for testing, as well as tweaking some JSON files to make life easier.

### Creating a file to run tests
1. Create a folder named 'tests' in the root of your project and create a file 'tests.js' in inside the new 'tests' folder. Really, you can name it or have it anywhere you want but it's simpler this way.
2. For now, put a dummy test in there just to make it easier things are working fine while we set it up.
```js
var assert = require('assert');
describe('Array', function () {
  describe('#indexOf()', function () {
    it('should return -1 when the value is not present', function () {
      assert.equal([1, 2, 3].indexOf(4), -1);
    });
  });
});
```
3. To test whether it's set up correctly so far, run this in command line in the root of your project.
```
./node_modules/mocha/bin/mocha.js tests
```
If you used different names or file paths from the steps above then replace 'tests' with the name of the folder containing your test js file(s) and adjust the path.

If everything is working fine, you should see the test pass:

<img src="https://i.gyazo.com/ffc401758dd62cfb03bc40bc8d395835.png" />

### Running tests through npm
It's a bit of a bother to have to run tests using that long command line command so let's set up an easier way using npm.

1. In your project's 'package.json' file, add this to the "scripts" property.
```json
"test": "mocha tests",
```
If your package.json file does not have a scripts property somehow, you can make one on your own.
```json
...
{
    "test": "mocha tests",
}
...
```
Again, adjust the 'tests' in the command to fit with whatever you might have done differently in the steps before.
2. You should be able to run the test now by using the command
```
npm run test
```

## What is a test?
Now that we've set up our test(s) we can actually start making tests using Mocha. Before we start, though, it's important we know what a test is.

A test is a chunk of code that performs an action, usually a function, and checks to see if the results are as expected. This way it is easy to tell if any changes made have broken anything in your project when run later on in development.

## Making a test

To start, let's break down the example test we used before in the 'test.js' file.
```js
// 1st describe
describe('Array', function () {
  // 2nd describe
  describe('#indexOf()', function () {
    // 1st (and only) it
    it('should return -1 when the value is not present', function () {
      // 1st and only assertion
      assert.equal([1, 2, 3].indexOf(4), -1);
    });
  });
});
```
That's a lot of functions for one test but it's not that bad. As you can see, there are 3 (or 4 if you count both describes) parts to this block of code:
### Assertion
Assertions are (usually) methods that return either true or false. If it returns true, the test passes. Otherwise, the test fails or blows up (throws an error/exception) D:. In this example, we're using the .equal assertion method which takes 2 values and returns true if they are equal.

There are quite a lot of different ways to assert which we will go over soon. If you want, there are extra resources available from [Mocha](https://mochajs.org/#assertions) and [Chai](https://www.chaijs.com/guide/styles/#expect) for more assertions other than .equal.

### It
It is a method that takes a test's name ('should return -1...' in this case) and a function which contains some kind of set up for an assertion and the assertion itself.

### Describe
Describe is a method that takes a name (like the 2nd describe '#indexOf()') and a function that contains an It method. Describe functions can also contain other describe functions which can help in sorting tests making them more comprehendable (such as multiple tests for the same function) or running different groups of tests seperately.

Now that we know what each part of the example code does, let's see how we would add our own tests.
1. First we'll make a function (in this example, we'll keep it in the test file, but it is recommended to import/require it from another file to reduce redundancy).
```js
// simple function to add 5000 to a given value and return it
function add5000(value) {
    return value + 5000;
}
```
2. Then we will make a new It function under the second describe function to put the function to the test.
```js
// a test that makes sure the add5000 function works
it('add5000 function works', function() {
    let variable1 = 120;
    let variable2 = add5000(variable1);
    assert.notEqual(variable2, variable1);
    assert.equal(variable2, variable1 + 5000);
});
```
3. Putting this all together, the test file will look something like this.
```js
var assert = require('assert');
describe('Array', function () {
  describe('#indexOf()', function () {
    it('should return -1 when the value is not present', function () {
      assert.equal([1, 2, 3].indexOf(4), -1);
    });
    it('add5000 function works', function() {
        let variable1 = 120;
        let variable2 = add5000(variable1);
        assert.equal(variable2, variable1 + 5000);
    });
  });
});
function add5000(value) {
    return value + 5000;
}
```

4. Run the test using
```
npm run test
```
which should give the following results:

<img src="https://i.gyazo.com/1ce5a375f7e5b51b100a742605c6a43f.png" />

## Other Assertions
There are loads of different assertion methods within the 'assert' library built into JavaScript such as .notEqual which is the opposite of the .equal used so far.
```js
let var1 = 5;
let var2 = add5000(var1);
assert.notEqual(var2, var1); // returns true - test passes
```

There are also other libraries that can be used for assertions like the Chai package we installed earlier. Chai has a lot of assertion 'styles' like [expect](https://www.chaijs.com/api/bdd/) which can allow for chaining of methods to form almost English-like assertions.

We can start using Chai's expect assertions by first importing it into our test file:
```js
// chai has others assertions you can use. just replace the .expect with .should or .assert.
// Or just import chai as a whole and use it as is.
var expect = require('chai').expect;
```

An example of Chai's expect assertions is:
```js
/*
    old version:

    let var1 = 5;
    let var2 = add5000(var1);
    assert.notEqual(var2, var1); // returns true - test passes
*/

// Chai version assertion
expect(var2).to.not.equal(var1);
```

Putting everything together, we can make a new describe for Chai tests to test on the add5000 function:
```js
describe('Chai tests', function () {
    describe('add5000 tests', function() {
        it('add5000 function still works', function() {
            // setup
            let var1 = 20;
            // function being tested
            let var2 = add5000(var1);
            // assertion(s)
            expect(var2).to.not.equal(var1);
            expect(var2).to.equal(var1 + 5000);
        });
        it('add5000 function deals with integers', function() {
            // setup
            let var1 = 20;
            // function being tested
            let var2 = add5000(var1);
            // assertion(s)
            expect(var1).to.be.a('number');
            expect(var2).to.not.be.a('string');
        });
    });
});
```
