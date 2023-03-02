<script setup lang="ts">
import type { Text } from 'vue';

</script>

<template>
    <table>
      <tr>
        <td>Competition nr</td>
        <td><input type="text"></td>
      </tr>
      <tr>
        <td>Competition name</td>
        <td><input type="text"></td>
      </tr>
      <tr>
        <td>Competition type</td>
        <td><input type="text"></td>
      </tr>
      <tr>
        <td>Competition date and time</td>
        <td><input type="text"></td>
      </tr>
      <tr>
        <td>Competition recurrence</td>
        <td><input type="text"></td>
      </tr>
      <tr>
        <td>Number of tables and boards</td>
        <td><input type="text"></td>
      </tr>
      <tr>
        <td>Scoring</td>
        <td><input type="text"></td>
      </tr>
      <tr>
        <td>Invite participants</td>
        <td><input type="text"></td>
      </tr>
      <tr>
        <td>Maximum #participants</td>
        <td><input type="number"></td>
      </tr>
      <tr>
        <td>Fill empty seats with robots</td>
        <td><input type="checkbox"></td>
      </tr>
      <tr>
        <td>Time limit</td>
        <td><input type="number"></td>
      </tr>
      <tr>
        <td>Audio enabled</td>
        <td><input type="checkbox"></td>
      </tr>
      <tr>
        <td>Video enabled</td>
        <td><input type="checkbox"></td>
      </tr>
      <tr>
        <td>Private tournament</td>
        <td><input type="checkbox"></td>
      </tr>
      <tr>
        <td>Undo trick (if private = yes)</td>
        <td><input type="checkbox"></td>
      </tr>
    </table>
    <button>START COMPETITION</button>
  </template>