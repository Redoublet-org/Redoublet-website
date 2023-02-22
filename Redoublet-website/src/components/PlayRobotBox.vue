<script setup lang="ts">

</script>

<template>
  <div>
    <h1>Play Against a Robot</h1>
    <router-link to="/robot-random-board" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">RANDOM BOARD</button>
    </router-link>
    <router-link to="/robot-competition" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">COMPETITION</button>
    </router-link>
  </div>
</template>

<style scoped>
h1 {
  font-weight: 500;
  font-size: 2.6rem;
  top: -10px;
}

h3 {
  font-size: 1.2rem;
}

.greetings h1,
.greetings h3 {
  text-align: center;
}

@media (min-width: 1024px) {
  .greetings h1,
  .greetings h3 {
    text-align: left;
  }
}
</style>