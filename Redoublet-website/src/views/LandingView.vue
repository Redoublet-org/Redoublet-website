<script setup lang="ts">
import HomePageVideo from "../components/HomePageVideo.vue";
</script>

<template>
  <main>
    <h1>REDOUBLET.COM</h1>
    <button class="btn">test</button>
    <HomePageVideo />
    <router-link to="/login" custom v-slot="{ navigate }">
    <button @click="navigate" role="link">LOGIN</button>
  </router-link>
    <router-link to="/create-account" custom v-slot="{ navigate }">
    <button @click="navigate" role="link">CREATE ACCOUNT</button>
  </router-link>
    <p>Start your free one-month trial</p>
    <a>CLUB LOGIN</a>

  </main>
</template>
