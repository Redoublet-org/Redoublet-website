<script setup lang="ts">
import { onMounted } from 'vue';

const props = defineProps({
  data: Array,
  columns: Array,
});
</script>

<template>
    <table align="right">
      <thead>
      <tr>
        <th v-for="key in columns">
          {{ key }}
        </th>
      </tr>
    </thead>
    <tbody>
      <tr v-for="row in data">
        <td v-for="key in columns">
          {{ row[key] }}
        </td>
      </tr>
    </tbody>
  </table>
</template>

<style scoped>
table, th, td {
  border: 1px solid;
  padding: 5px;
}

th {
  background-color: black;
  color: white;
}

table{
  margin-top: 100px;
}
</style>