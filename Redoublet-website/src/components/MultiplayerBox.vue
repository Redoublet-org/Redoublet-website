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
    <router-link to="/multiplayer-competition" custom v-slot="{ navigate }">
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