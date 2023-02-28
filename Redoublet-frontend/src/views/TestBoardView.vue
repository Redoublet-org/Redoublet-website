<script setup lang="ts">

const startGame = async () => {
    const response = await fetch('http://localhost:5000/api/StartGame?Name1=a&Name2=b&Name3=c&Name4=d&');
    const result = await response.json();
    console.log(result)
}


</script>

<template>
    <p>yo</p>
    <!--
    <div>
        <button @click="startGame">Start</button>
    </div>
    -->
</template>