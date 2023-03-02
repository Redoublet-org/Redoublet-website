<script setup lang="ts">

</script>

<template>
    <router-link to="/menu" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">BACK</button>
    </router-link>
    <div class="row">
        <div class="column">
            <router-link to="/multiplayer-tournaments/join" custom v-slot="{ navigate }">
                <div 
                class="btn"
                @click="navigate"
                >
                Join existing tournament
                </div>
            </router-link>
            <router-link to="/multiplayer-tournaments/setup" custom v-slot="{ navigate }">
                <div 
                class="btn"
                @click="navigate"
                >
                Setup new online tournament
                </div>
            </router-link>
            <router-link to="/multiplayer-tournaments/setup-live" custom v-slot="{ navigate }">
                <div 
                class="btn"
                @click="navigate"
                >
                Setup new live tournament
                </div>
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