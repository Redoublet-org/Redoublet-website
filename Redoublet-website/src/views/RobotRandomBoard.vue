<script setup lang="ts">
    import RobotGameOption from "../components/RobotGameOption.vue";
</script>

<template>
    <main>
    <router-link to="/menu" custom v-slot="{ navigate }">
        <button class="btn back" @click="navigate" role="link">BACK</button>
    </router-link>
    <RobotGameOption />
    </main>
</template>


<style scoped>
.back {
    border: 3px solid;
    margin-left: 10px;
}

</style>