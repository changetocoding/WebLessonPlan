# Intro to Vue Js
https://guides.github.com/features/mastering-markdown/

### Vue.js website
https://vuejs.org/  
v2 guide: https://vuejs.org/v2/guide/



### Important
We are going to be doing vue 2. Vue 3 is the latest but David doesn't know

### First vue website 
You can do vue in 1 of 2 ways:
1. Include the vue library in your html file
2. Using vue-cli and node based tools.

We will focus on method 2.

### Installation
See: https://vuejs.org/v2/guide/installation.html#NPM

1. Install Node
2. Install vue cli. Open up a command prompt. Run:
```
npm install -g @vue/cli
```
3. Create a project:
```
vue create my-project
```
4. Add vue router
```
cd my-project
vue add router
```
Select 'Y' for the history mode 

5. Run your project. Make sure you are in the 'my-project' directory
```
npm run serve
```
6. Open http://localhost:8080/ in your browser. This will also live update as you save code files
7. (Obviously) Check into your source control using git.
8. Install the vue devtools plugin: https://chrome.google.com/webstore/detail/vuejs-devtools
9. 

## Go through the vue tutorial
Start here: https://vuejs.org/v2/guide/#Declarative-Rendering

## Break 1: Stop after 
- Template syntax
- for loops
- (maybe) Able to create new component and register it
- Know difference between data, props and computed


Get to create product details page using for loop

ProductDetails.vue
```
<template>
  <div>

  </div>
</template>

<script>
  export default {
    
  }
</script>

<style scoped>

</style>
```
in router/index.js register it as a route with a path
```
...
import About from '../views/About.vue'
import ProductDetails from '../views/ProductDetails.vue'

...

const routes = [
  ...
  {
    path: '/productDetails',
    component: ProductDetails
  }
]
```


## Vue single file component
https://vuejs.org/v2/guide/single-file-components.html

Hmtl, js and styling for a component all in one place

```
<template>
  <p>{{ greeting }} World!</p>
</template>

<script>
export default {
  props: {
    greeting: String
  }
}
</script>

<style scoped>
p {
  font-size: 2em;
  text-align: center;
}
</style>
```


# Bonsai tasks:
1. Create a products list page using v-for directive
2. Create a products Details page using router to pass the id as a prop to the component
3. Refactor products list page to use a component
4. Implement add to basket button


## Event handling
https://vuejs.org/v2/guide/events.html

In vue js communication downwards. What if we want to reverse direction? Events

### DOM Events
Vue supports DOM events
```html
<button v-on:click="onAddOne">Add 1</button>
<p>The button above has been clicked {{ counter }} times.</p>
```
```js
export default {
  data() {
    return {
      counter: 0
    }
  },
  methods: {
    onAddOne() {
      this.counter = this.counter + 1;
      alert('Count ' + this.counter + '!')
    }
  },
}
```

Shorthand for events is '@'
```html
<button @click="onAddOne">Add 1</button>
<p>The button above has been clicked {{ counter }} times.</p>
```

### Your custom events
In vue you can create your own events
https://vuejs.org/v2/guide/components.html#Listening-to-Child-Components-Events

In Child either
```js
this.$emit('myEvent')
```
Or 
```html
<button v-on:click="$emit('myEvent')">
  Enlarge text
</button>
```

In Parent
```
<my-component @:myEvent="doSomething"></my-component>
```

You can also emit a value with the event




