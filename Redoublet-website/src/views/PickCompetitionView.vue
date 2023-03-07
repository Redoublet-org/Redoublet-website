<script setup lang="ts">
import Competitions from "../components/Competitions.vue";
</script>

<template>
    <main>
        <router-link to="/robot-competition" custom v-slot="{ navigate }">
            <button class="btn back" @click="navigate" role="link">BACK</button>
        </router-link>
        <Competitions />
    </main>
</template>

<style scoped>
.back {
    border: 3px solid;
    margin-left: 10px;
}
</style>