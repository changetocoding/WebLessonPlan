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
4. Run your project 
```
cd my-project
npm run serve
```
5. acd
6. (Obviously) Check into your source control using git
Use this gitignore:
```
.DS_Store
node_modules
/dist

# local env files
.env.local
.env.*.local

# Log files
npm-debug.log*
yarn-debug.log*
yarn-error.log*
pnpm-debug.log*

# Editor directories and files
.vscode
```






```js
var app = new Vue({
  el: '#app',
  data: {
    message: 'Hello Vue!'
  }
})
```
