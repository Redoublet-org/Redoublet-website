<script setup lang="ts">
let ranking = 1000;
</script>

<template>
  <div>
    <p>RANKING: {{ ranking }}</p>
  </div>
</template>

<style scoped>
div {
  border: 3px solid;
  border-radius: 8px;
}

p {
  margin-top: 6px;
  margin-bottom: 6px;
  text-align: center;
}
</style>