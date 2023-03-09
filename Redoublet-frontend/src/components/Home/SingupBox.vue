<script setup lang="ts">

</script>

<template>
  <div class="container">
    <form>
      <p><b>Username</b></p>
      <input type="text">
      <p><b>Email address</b></p>
      <input type="email">
      <p><b>Password</b></p>
      <input type="password">
      <router-link to="menu" custom v-slot="{ navigate }">
        <button class="btn btn-dark" @click="navigate" role="link">Sign Up</button>
      </router-link>
    </form>
  </div>
</template>

<style scoped>
p {
  margin-top: 10px;
  margin-bottom: 0px;
}

input {
  width: 100%;
  background: transparent;
  border: 3px solid;
}

a {
  color: #000;
}

button {
  margin-top: 20px;
  margin-bottom: 10px;
  width: 100%;
}

.container {
  width: 30%;
  margin-top: 100px;
}
</style>