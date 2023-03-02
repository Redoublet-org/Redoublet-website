<script setup lang="ts">

import { ref } from 'vue'

let result = ref<string | null>(null)
let isResultReady = false

const startGame = async () => {
    const response = await fetch('http://localhost:5000/api/StartGame', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            Name1: 'Speler 1',
            Name2: 'Speler 2',
            Name3: 'speler 3',
            Name4: 'speler 4',
        })
    })

    const JSONresult = await response.json()
    result = JSONresult
    isResultReady = true
}


</script>

<template>
    <p>yo</p>
    <div>
        <button @click="startGame">Start</button>
    </div>

    <div v-if="isResultReady">
        {{ result }}
    </div>

</template>