<script setup lang="ts">
import type { Text } from 'vue';

</script>

<template>
    <table align="center">
      <tr>
        <th>Competition nr</th>
        <td><input class="form-control" type="text"></td>
      </tr>
      <tr>
        <th>Competition name</th>
        <td><input class="form-control" type="text"></td>
      </tr>
      <tr>
        <th>Competition type</th>
        <td><input class="form-control" type="text"></td>
      </tr>
      <tr>
        <th>Competition date and time</th>
        <td><input class="form-control" type="text"></td>
      </tr>
      <tr>
        <th>Competition recurrence</th>
        <td><input class="form-control" type="text"></td>
      </tr>
      <tr>
        <th>Number of tables and boards</th>
        <td><input class="form-control" type="text"></td>
      </tr>
      <tr>
        <th>Scoring</th>
        <td><input class="form-control" type="text"></td>
      </tr>
      <tr>
        <th>Invite participants</th>
        <td><input class="form-control" type="text"></td>
      </tr>
      <tr>
        <th>Maximum #participants</th>
        <td><input class="form-control" type="number"></td>
      </tr>
      <tr>
        <th>Fill empty seats with robots</th>
        <td><input class="form-check-input" type="checkbox"></td>
      </tr>
      <tr>
        <th>Time limit</th>
        <td><input class="form-control" type="number"></td>
      </tr>
      <tr>
        <th>Audio enabled</th>
        <td><input class="form-check-input" type="checkbox"></td>
      </tr>
      <tr>
        <th>Video enabled</th>
        <td><input class="form-check-input" type="checkbox"></td>
      </tr>
      <tr>
        <th>Private tournament</th>
        <td><input class="form-check-input" type="checkbox"></td>
      </tr>
      <tr>
        <th>Undo trick (if private = yes)</th>
        <td><input class="form-check-input" type="checkbox"></td>
      </tr>
    </table>
    <button class="my-4">START COMPETITION</button>
  </template>

<style scoped>

th {
  background-color: black;
  color: white;
  border: 1px white solid;
  width: 300px;
  padding-left: 10px;
  height: 35px;
}

td {
  border: 1px solid;
}

input {
  background-color: transparent;
}

.form-check-input {
  border: 1px solid;
  margin-left: 10px;
}

button {
  width: 30%;
  margin-left: 35%;
  background-color: #00368C;
  color: white;
  height: 40px;
}

</style>