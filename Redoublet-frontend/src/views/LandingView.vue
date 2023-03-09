<script setup lang="ts">
import HomePageVideo from "../components/HomePageVideo.vue";
</script>

<template>
  <main>
    <div class="container">
      <h1>REDOUBLET<span class="orange">.COM</span></h1>
      <HomePageVideo />
      <router-link to="/login" custom v-slot="{ navigate }">
        <button class="btn btn-dark" @click="navigate" role="link">LOGIN</button>
      </router-link>
      <br>
      <router-link to="/create-account" custom v-slot="{ navigate }">
        <button class="btn btn-primary" @click="navigate" role="link">CREATE ACCOUNT</button>
      </router-link>
      <p>Start your free one-month trial</p>
      <a href="">CLUB LOGIN</a>
    </div>
  </main>
</template>

<style scoped>
button {
  margin-top: 20px;
  margin-bottom: 20px;
  width: 60%;
}

a {
  color: black;
}
.container {
  margin-top: 100px;
  width: 50%;
  margin-left: 25%;
  text-align: center;
}

.orange {
  color: #f89554;
}

</style>
