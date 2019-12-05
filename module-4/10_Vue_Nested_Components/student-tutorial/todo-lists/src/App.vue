<template>
  <div id="app">
    <todo-search v-on:filter-tasks="handleSearch"></todo-search>
    <todo-list title="My Work Todo's" v-bind:todos="work" v-bind:search="search" ></todo-list>
    <todo-list title="My Personal Todo's" v-bind:todos="personal" v-bind:search="search" ></todo-list>
    <todo-list title="My Household Todo's" v-bind:todos="household" v-bind:search="search" ></todo-list>
  </div>
</template>

<script>
import TodoSearch from '@/components/TodoSearch';
import TodoList from '@/components/TodoList';

export default {
  name: 'app',
  components: {
    TodoSearch,
    TodoList
  },
  data() {
    return {
      search: '',
      work: [],
      personal: [],
      household: []
    }
  },
  methods: {
      handleSearch(query) {
          console.log('Filter Tasks: ', query);
          this.search = query;
      }
  }
}
</script>

<style>
body {
  background: rgb(74,162,244);
  background: radial-gradient(circle, rgba(74,162,244,1) 0%, rgba(54,131,240,1) 100%);
}

#app {
  display: grid;
  grid-template-columns: 1fr 1fr 1fr;
  grid-gap: 20px;
}

.search { 
  grid-column: 2 / 3;
  grid-row: 1;
}
.todo-list {
  grid-row: 2;
}
</style>

