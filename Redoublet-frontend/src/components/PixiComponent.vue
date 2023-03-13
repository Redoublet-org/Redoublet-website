<template>
    <div id="container"></div>
    
</template>
  
<script setup lang="ts">
import * as PIXI from "pixi.js";
import { Application, Sprite } from "pixi.js";
import { onMounted } from "vue";

const app = new Application({
    width: 640,
    height: 480,
    backgroundColor: 0x1099bb,
    renderer: "auto"
});



onMounted(() => {
    const myDiv = document.getElementById("container");
    myDiv.appendChild(app.view);

    const sprite = PIXI.Sprite.from("src/assets/Logo.png");
    sprite.width = 360;
    sprite.height = 480;
    sprite.x = 130;
    sprite.y = 0;
    app.stage.addChild(sprite);
});
</script>
  
<style scoped>
div {
    width: 640px;
    height: 480px;
    margin-left: 20%;
    position: relative;
    z-index: 1;
}
</style>
  