<script setup lang="ts">

</script>

<template>
  <div>
    <h1>Play Against a Robot</h1>
    <div>
        <router-link to="/robot-random-board" custom v-slot="{ navigate }">
            <button @click="navigate" role="link">RANDOM BOARD</button>
        </router-link>
        <router-link to="/robot-competition" custom v-slot="{ navigate }">
            <button @click="navigate" role="link">COMPETITION</button>
        </router-link>
    </div>
  </div>
</template>

<style scoped>

</style>