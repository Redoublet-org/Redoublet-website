<script setup lang="ts">
import CreateGameTable from "../components/CreateGameTable.vue";
</script>

<template>
    <router-link to="/multiplayer-table" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">BACK</button>
    </router-link>
    <CreateGameTable />
</template>
