<script setup lang="ts">
import JoinGameTable from "../components/JoinGameTable.vue";
</script>

<template>
    <router-link to="/multiplayer-table" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">BACK</button>
    </router-link>
    <JoinGameTable />
</template>
