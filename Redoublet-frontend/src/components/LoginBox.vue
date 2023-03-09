<script setup lang="ts">

</script>

<template>
  <div class="container">
    <form>
      <p><b>Email address</b></p>
      <input class="form-control" type="email" placeholder="Email adress">
      <p><b>Password</b></p>
      <input class="form-control" type="password" placeholder="Password">
      <router-link to="/menu" custom v-slot="{ navigate }">
        <button class="btn btn-dark" @click="navigate" role="link">Login</button>
      </router-link>
    </form>
    <a href="">Forgot password</a>
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

a{
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