<script setup lang="ts">
import { ref } from "vue";

var week = new Date();
var day = week.getDay();
var conversion = (7 - day) * 60 * 60 * 24 * 1000; //find amount of time between today's date and sunday in ms
var time = week.getTime();
var v = time + conversion;
week.setTime(v);
var now = new Date();

const weekDate = ref(week.getDate() + '/' + (week.getMonth() + 1) + ' 23:59h');
const today = ref(now.getDate() + '/' + (now.getMonth() + 1) + ' 23:59h');
</script>

<template>
  <div class="container">
    <div class="row">

      <div class="col-5">
        <h3>DAILY COMPETITION</h3>
        <br>
        <router-link to="/daily-competition" custom v-slot="{ navigate }">
          <button @click="navigate" role="link"><u>PLAY</u><br>(Deadline: {{ today }})</button>
        </router-link>
      </div>
      <div class="col-5 offset-2">
        <h3>WEEKLY COMPETITION</h3>
        <br>
        <router-link to="/weekly-competition" custom v-slot="{ navigate }">
          <button @click="navigate" role="link"><u>PLAY</u><br>(Deadline: {{ weekDate }})</button>
        </router-link>
      </div>
    </div>
  </div>
</template>

<style scoped>
.container {
  width: 60%;
  left: 30%;
  margin-top: 100px;
}

button {
  width: 100%;
  background-color: #1D9EFF;
  border: 1px white solid;
  color: white;
  font-family: Arial, Helvetica, sans-serif;
  font-weight: 600;
  padding-top: 14px;
  padding-bottom: 14px;
  font-size: 20px;
}

h3 {
  text-align: center;
  width: 100%;
  background-color: #00368C;
  border: 1px white solid;
  color: white;
  font-family: Arial, Helvetica, sans-serif;
  font-weight: 600;
  padding-top: 32px;
  padding-bottom: 32px;
  font-size: 20px;
}
</style>