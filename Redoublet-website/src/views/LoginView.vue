<script setup lang="ts">
import LoginBox from "../components/LoginBox.vue";
</script>

<template>
    <router-link to="/" custom v-slot="{ navigate }">
        <button class="btn back" @click="navigate" role="link">BACK</button>
    </router-link>
    <div>
        <LoginBox />
    </div>
</template>

<style scoped>
.back {
    border: 3px solid;
    margin-left: 10px;
}
</style>