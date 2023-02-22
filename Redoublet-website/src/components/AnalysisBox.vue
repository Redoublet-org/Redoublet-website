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