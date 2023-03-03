<script setup lang="ts">
    import Weekly from "../components/Competitions.vue";
</script>

<template>
    <main>
    <router-link to="/robot-competition" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">BACK</button>
    </router-link>
    <Weekly />
    </main>
</template>