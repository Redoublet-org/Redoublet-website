<script setup lang="ts">

</script>

<template>
    <router-link to="/menu" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">BACK</button>
    </router-link>
    <div class="row">
        <div class="column">
            <router-link to="/multiplayer-competitions/join" custom v-slot="{ navigate }">
                <button @click="navigate">join existing</button>
            </router-link>
            <router-link to="/multiplayer-competitions/setup" custom v-slot="{ navigate }">
                <button @click="navigate">new online</button>
            </router-link>
        </div>
    </div>
</template>

<style scoped>
.column {
    display: flex;
    flex-direction: column;
    align-self:center;
    justify-self:center;
}

.row {
    display: flex;
    justify-content: space-around;
    
}
</style>