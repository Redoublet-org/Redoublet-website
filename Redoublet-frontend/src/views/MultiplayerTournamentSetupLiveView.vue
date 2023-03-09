<script setup lang="ts">
import CreateGameGrid from "../components/CreateGameGrid.vue";
</script>

<template>
    <router-link to="/multiplayer-table" custom v-slot="{ navigate }">
        <button class="btn back" @click="navigate" role="link">BACK</button>
    </router-link>
    <CreateGameGrid />
</template>

<style scoped>
.back {
  border: 3px solid;
  margin-left: 10px;
}
</style>