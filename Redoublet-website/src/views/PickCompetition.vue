<script setup lang="ts">
    import Weekly from "../components/WeeklyCompetition.vue";
    import Daily from "../components/DailyCompetition.vue";
</script>

<template>
    <main>
    <router-link to="/robot-competition" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">BACK</button>
    </router-link>
    <Weekly />
    <Daily />
    </main>
</template>