<script setup lang="ts">

</script>

<template>
  <div class="box">
    <div class="mode mb-4">
      <h2>Online Multiplayer</h2>
    </div>
    <router-link to="/multiplayer-table" custom v-slot="{ navigate }">
      <button class="mb-2" @click="navigate" role="link">TABLE</button>
    </router-link>
    <router-link to="/multiplayer-tournaments" custom v-slot="{ navigate }">
      <button class="mb-2" @click="navigate" role="link">TOURNAMENTS</button>
    </router-link>
    <router-link to="/multiplayer-competitions" custom v-slot="{ navigate }">
      <button @click="navigate" role="link">COMPETITION</button>
    </router-link>
  </div>
</template>

<style scoped>
h2 {
  color: white;
  font-size: 32px;
  font-weight: 700;
}

button {
  width: 100%;
  background-color: #80ACBA;
  border: 1px white solid;
  color: black;
  padding-top: 5px;
  padding-bottom: 5px;
  font-size: 18px;
}

.mode {
  background-color: #426C79;
  padding-top: 39px;
  padding-bottom: 39px;
  border: 1px white solid
}

.box {
  text-align: center;
}
</style>