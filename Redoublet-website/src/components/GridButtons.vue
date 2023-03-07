<script setup lang="ts">
const props = defineProps({
  number: Number,
  text: String,
  color: String,
});
</script>

<template>
  <div class="buttons">
    <div class="row" v-for="index in number">
      <button class="blue" v-if="color === 'blue'">
        {{ text }}
      </button>
      <button class="orange" v-if="color === 'orange'">
        {{ text }}
      </button>
    </div>
  </div>
</template>

<style scoped>
div {
  margin-left: 0px;
}

button {
  margin-left: 0px;
  height: 35px;
  color: white;
  text-decoration: underline;
  font-size: 20px;
}

.buttons {
  margin-top: 134px;
}

.blue {
  background-color: #426C79;
}

.orange {
  background-color: #B85741;
}
</style>