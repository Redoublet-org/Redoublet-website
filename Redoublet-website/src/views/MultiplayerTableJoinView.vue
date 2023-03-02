<script setup lang="ts">
import JoinGameGrid from "../components/JoinGameGrid.vue";
</script>

<template>
    <router-link to="/multiplayer-table" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">BACK</button>
    </router-link>
    <JoinGameGrid />
</template>
