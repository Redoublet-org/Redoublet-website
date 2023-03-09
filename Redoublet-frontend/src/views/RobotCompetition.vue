<script setup lang="ts">
    import RobotCompetitionOption from "../components/RobotCompetitionOption.vue";
</script>

<template>
    <main>
    <router-link to="/menu" custom v-slot="{ navigate }">
        <button class="btn back" @click="navigate" role="link">BACK</button>
    </router-link>
    <RobotCompetitionOption />
    </main>
</template>

<style scoped>
.back {
    border: 3px solid;
    margin-left: 10px;
}
</style>