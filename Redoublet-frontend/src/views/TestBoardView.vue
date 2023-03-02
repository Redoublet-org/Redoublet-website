<script setup lang="ts">

import { ref } from 'vue'

let result = ref< | null>(null)
let isResultReady = ref(false)

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
    result.value = JSONresult
    isResultReady.value = true
}


</script>

<template>
    <div>
        <button @click="startGame">Start</button>
    </div>

    <div v-if="isResultReady">
        <div v-for="(players, dealer, round, trump, currentPlayer, tricks) in result">
            <div v-for="(player in players)"> 
                <p>{{ player.name }}</p>
            </div>
        </div>  
    </div>

</template>