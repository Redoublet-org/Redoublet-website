<script setup lang="ts">
    import MultiplayerTournamentOptions from '@/components/MultiplayerTournamentOptions.vue';
</script>

<template>
    <router-link to="/menu" custom v-slot="{ navigate }">
        <button class="back btn" @click="navigate" role="link">BACK</button>
    </router-link>
    <MultiplayerTournamentOptions />
</template>

<style scoped>
.back {
    border: 3px solid;
    margin-left: 10px;
}
</style>