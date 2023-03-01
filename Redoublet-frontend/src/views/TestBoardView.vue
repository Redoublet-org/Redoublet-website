<script setup lang="ts">

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

    });
    const result = await response.json();
    console.log(result)
}


</script>

<template>
    <p>yo</p>
    <div>
        <button @click="startGame">Start</button>
    </div>
</template>