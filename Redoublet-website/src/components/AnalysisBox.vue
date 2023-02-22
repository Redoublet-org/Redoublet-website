<script setup lang="ts">

</script>

<template>
  <div>
    <h1>Replay and Analyse Games Played</h1>
    <router-link to="/overview" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">OVERVIEW OF GAMES PLAYED</button>
    </router-link>
  </div>
</template>

<style scoped>

</style>