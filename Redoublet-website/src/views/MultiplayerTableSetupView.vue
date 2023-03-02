<script setup lang="ts">
import CreateGameGrid from "../components/CreateGameGrid.vue";
</script>

<template>
    <router-link to="/multiplayer-table" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">BACK</button>
    </router-link>
    <CreateGameGrid />
</template>
