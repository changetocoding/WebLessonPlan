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
7. (Obviously) Check into your source control using git. Use the gitignore here: https://github.com/changetocoding/VueDemo


## Go through the vue tutorial
Start here: https://vuejs.org/v2/guide/#Declarative-Rendering

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




