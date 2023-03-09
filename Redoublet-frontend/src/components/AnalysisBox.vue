<script setup lang="ts">

</script>

<template>
  <div class="box">
    <div class="mode mb-4">
      <h2>Replay and Analyse<br>Played Games</h2>
    </div>
    <router-link to="/overview" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">OVERVIEW OF GAMES PLAYED</button>
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
  background-color: #D29B89;
  border: 1px white solid;
  color: black;
  padding-top: 5px;
  padding-bottom: 5px;
  font-size: 18px;
}

.mode{
  background-color: #B85741;
  padding-top: 20px;
  padding-bottom: 20px;
  border: 1px white solid
}

.box {
  text-align: center;
}
</style>