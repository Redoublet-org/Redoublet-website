<script setup lang="ts">
import MenuButton from "../components/MenuButton.vue"

</script>

<template>
    <div class="row">
        <div class="column">
            <MenuButton
                @click=""
                btnText="button1"
            />
            <MenuButton
                @click=""
                btnText="button2"
            />
            <MenuButton
                @click=""
                btnText="button3"
            />
        </div>
        <div class="column">
            <MenuButton
                @click=""
                btnText="button1"
            />
            <MenuButton
                @click=""
                btnText="button2"
            />
            <MenuButton
                @click=""
                btnText="button3"
            />
        </div>
        <div class="column">
            <MenuButton
                @click=""
                btnText="button1"
            />
            <MenuButton
                @click=""
                btnText="button2"
            />
            <MenuButton
                @click=""
                btnText="button3"
            />
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