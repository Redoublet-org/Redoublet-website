<script setup lang="ts">

</script>

<template>
  <div>
    <h1>Online Multiplayer</h1>
    <router-link to="/multiplayer-table" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">TABLE</button>
    </router-link>
    <router-link to="/multiplayer-tournaments" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">TOURNAMENTS</button>
    </router-link>
    <router-link to="/multiplayer-competitions" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">COMPETITION</button>
    </router-link>
  </div>
</template>

<style scoped>

</style>