<script setup lang="ts">

</script>

<template>
    <div class="container">
        <router-link to="/multiplayer-table/join" custom v-slot="{ navigate }">
            <button class="my-5" @click="navigate">Join existing table</button>
        </router-link>
        <router-link to="/multiplayer-table/setup" custom v-slot="{ navigate }">
            <button @click="navigate">Setup new (private) table</button>
        </router-link>
    </div>
</template>

<style scoped>
.container {
    width: 30%;
    left: 35%;
    margin-top: 100px;
}

button {
    width: 100%;
    background-color: #00368C;
    border: 1px white solid;
    color: white;
    font-family: 'Times New Roman', Times, serif;
    font-weight: 600;
    padding-top: 20px;
    padding-bottom: 20px;
    font-size: 20px;
}
</style>