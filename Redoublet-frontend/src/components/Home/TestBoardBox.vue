<script setup lang="ts">

</script>

<template>
  <div>
    <h1>Test Board</h1>
    <router-link to="/test-board" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">open test board</button>
    </router-link>
  </div>
</template>

<style scoped>

</style>