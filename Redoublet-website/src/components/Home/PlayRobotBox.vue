<script setup lang="ts">

</script>

<template>
  <div class="box">
    <div class="mode mb-4">
      <h2>Play<br>Against Robot</h2>
    </div>
    <router-link to="/robot-random-board" custom v-slot="{ navigate }">
      <button class="mb-3" @click="navigate" role="link">RANDOM BOARD</button>
    </router-link>
    <router-link to="/robot-competition" custom v-slot="{ navigate }">
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
  background-color: #00368C;
  border: 1px white solid;
  color: white;
  padding-top: 5px;
  padding-bottom: 5px;
  font-size: 18px;
}

.mode {
  background-color: #000712;
  padding-top: 20px;
  padding-bottom: 20px;
  border: 1px white solid
}

.box {
  text-align: center;
}
</style>