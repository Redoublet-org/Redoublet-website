<script setup lang="ts">
import MultiplayerTableOptions from '../../components/Multiplayer/MultiplayerTableOptions.vue';
</script>

<template>
    <router-link to="/menu" custom v-slot="{ navigate }">
        <button class="btn back" @click="navigate" role="link">BACK</button>
    </router-link>
    <MultiplayerTableOptions />
</template>

<style scoped>
.back {
    border: 3px solid;
    margin-left: 10px;
}
</style>