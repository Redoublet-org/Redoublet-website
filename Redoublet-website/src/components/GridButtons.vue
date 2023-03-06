<script setup lang="ts">
const props = defineProps({
  number: Number,
  text: String,
})
</script>

<template>
      <button v-for="index in number">
        {{ text }}
      </button>
</template>