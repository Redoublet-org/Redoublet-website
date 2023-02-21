<script setup lang="ts">
import LoginBox from "../components/LoginBox.vue";
</script>

<template>
    <router-link to="/" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">BACK</button>
    </router-link>
    <h1>Login</h1>
    <LoginBox />
</template>
