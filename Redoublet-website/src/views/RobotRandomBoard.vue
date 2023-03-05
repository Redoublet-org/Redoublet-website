<script setup lang="ts">
    import RobotGameOption from "../components/RobotGameOption.vue";
</script>

<template>
    <main>
    <router-link to="/menu" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">BACK</button>
    </router-link>
    <RobotGameOption />
    </main>
</template>