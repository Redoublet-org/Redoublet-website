<script setup lang="ts">

</script>

<template>
  <div>
    <form>
      <p>Email address</p>
      <input type="email">
      <p>Password</p>
      <input type="password">
      <router-link to="/menu" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">Login</button>
      </router-link>
    </form>
    <a>Forgot password</a>
  </div>
</template>