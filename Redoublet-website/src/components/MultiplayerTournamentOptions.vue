<script setup lang="ts">
</script>

<template>

<div class="container">
    <router-link to="/multiplayer-tournaments/join" custom v-slot="{ navigate }">
        <button class="mt-5 mb-3" @click="navigate">Join existing tournament</button>
    </router-link>
    <router-link to="/multiplayer-tournaments/setup" custom v-slot="{ navigate }">
        <button class="mb-3" @click="navigate">Setup new online tournament</button>
    </router-link>
    <router-link to="/multiplayer-tournaments/setup-live" custom v-slot="{ navigate }">
        <button @click="navigate">Setup new live tournament</button>
    </router-link>
</div>
</template>

<style scoped>

.container {
    width: 30%;
    left: 35%;
    margin-top: 100px;
}

button{
    width: 100%;
    background-color: #00368C;
    border: 1px white solid;
    color: white;
    font-family:'Times New Roman', Times, serif;
    font-weight: 600;
    padding-top: 20px;
    padding-bottom: 20px;
    font-size: 20px;
}
</style>