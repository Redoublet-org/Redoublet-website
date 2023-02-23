<script setup lang="ts">
import SignupBox from "../components/SingupBox.vue";
</script>

<template>
    <router-link to="/" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">BACK</button>
    </router-link>
    <h1>Create Account</h1>
    <SignupBox />
</template>
