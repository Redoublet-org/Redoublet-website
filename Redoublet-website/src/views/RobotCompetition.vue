<script setup lang="ts">
    import RobotCompetitionOption from "../components/RobotCompetitionOption.vue";
</script>

<template>
    <main>
    <router-link to="/menu" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">BACK</button>
    </router-link>
    <RobotCompetitionOption />
    </main>
</template>