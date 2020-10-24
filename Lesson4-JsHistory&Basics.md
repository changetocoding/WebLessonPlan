# Lesson

# Lesson objectives
- History of JS.
- Variables and data types in js


# Lesson time to deliever:

# Teacher instruction
### JS has a very interesting history so try to get that cross:
- It was invented in weeks. Most languages are invented in months or years
- It was named Javascript to steal from the popularity of Java which was the hottest language at that time. Backfired now as JS is most popular language in the world and Java is gaining the benifits of that...
- The browser wars. Can make it into a cool game
- JS didnt change in 10 years. Can talk about the drama between Mircosoft (supported by Yahoo on the commitee) that had its own browser scripting language (JScript) vs the other 4 members of the committee. But best thing for JS as people invented tools to fill in its gaps and it was really stable when JScript and Flash it's main competitors were constantly changing. 
- Ajax - Asynchronous programming. Got invented for JS by open source projects. Now used in most other languages
- End with Modern js frameworks which we will cover in the future (React.js, 

- TODO Create a youtube video about the history of JS.


### Datatypes
- Cover this sparingly and more through examples. Don't cover bigInt, or the max and min of number (Never hit those limits myself)


### Label for
Explain "Label for" and other way of doing it: https://stackoverflow.com/questions/18432376/what-does-for-attribute-do-in-html-label-tag


The <label> tag allows you to click on the label, and it will be treated like clicking on the associated input element. There are two ways to create this association:
  
  
One way is to wrap the label element around the input element:
```html
<label>Input here:
    <input type='text' name='theinput' id='theinput'>
</label>
```
The other way is to use the for attribute, giving it the ID of the associated input:
```html
<label for="theinput">Input here:</label>
<input type='text' name='whatever' id='theinput'>
```
  
### Radio boxes
Explain that with radio buttons, need to have the same name in order to group them together
Explain the value vs what see on input label: Label is what gets displayed to the user. Value is the underlying value that will get set when they select that option. E.g. Can have labels "I am happy to proceed", "Not right now" with values "True", "False"

### Bootstrap button styling
https://getbootstrap.com/docs/4.0/components/buttons/

# Course materials
Slide deck by emmanuel.
Lesson code by emmanuel
https://getbootstrap.com/docs/4.0/components/forms


# Recommendations:
- Live server in vs code to live reload code
- Have a split screen setup so don't have to switch screens as often.

# Homework
- Create a login form
- Create a form to get data from user: name, ... address...
- Try out all the different button styles from https://getbootstrap.com/docs/4.0/components/buttons/
