<script setup lang="ts">
import { stringifyExpression } from "@vue/compiler-core";
import {defineProps} from "vue"

const props = defineProps<{
    btnText?: string
}>()

</script>

<template>
    <div class="btn">{{ btnText }}</div>
</template>

<style scoped>
    .btn {
        display: flex;
        align-items: center;
        justify-content: center;
        width: 10vw;
        height: 2vh;
        background-color: rgb(112, 112, 255);
        border-radius: 6px;
        border: 2px solid white;
        padding: 20px;
        margin: 4px;
    }
</style>