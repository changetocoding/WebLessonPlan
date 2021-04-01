# Lesson 

# Obsolete
Check out https://tbhp.gitbook.io/thebeta/lesson-plans/3.-bootstrap-and-user-input for latest version

# Lesson objectives
- Input fields: input, button, radio button
- Bootstrap input fields


# Lesson time to deliever:

# Teacher instruction
- Cover a getting user input: different input fields: label, input, textarea, checkbox, radio button, button
- Do not cover form
- Bootstrap - Go through bootstrap form controls

### Bootstrap 
Use the starter template here. https://getbootstrap.com/docs/4.5/getting-started/introduction/
Explain container & the grid system: https://getbootstrap.com/docs/4.5/layout/grid/


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


# Recommendations:
- Live server in vs code to live reload code
- Have a split screen setup so don't have to switch screens as often.

# Homework
- Create a login form
- Create a form to get data from user: name, ... address...
- Try out all the different button styles from https://getbootstrap.com/docs/4.0/components/buttons/
- Do bootstrap grid tutorial - https://designmodo.com/bootstrap-grid/ and https://getbootstrap.com/docs/4.5/layout/grid/
