<script setup lang="ts">

</script>

<template>
  <div>
    <form>
      <p>Username</p>
      <input type="text">
      <p>Email address</p>
      <input type="email">
      <p>Password</p>
      <input type="password">
      <router-link to="home" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">Sign Up</button>
      </router-link>
    </form>
  </div>
</template>