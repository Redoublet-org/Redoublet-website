<script setup lang="ts">
import JoinGameGrid from "../components/DefaultGrid.vue";
import GridButtons from "../components/GridButtons.vue";

const gridColumns = ['Table', 'Players', 'Partner system', 'Avg rating', 'Countdown']
const gridData = [
  { Table: '#1', Players: '2 / 4 ', 'Partner system': 'ACOL', 'Avg rating': '7.5', Countdown: '01:50m' },
  { Table: '#2', Players: '1 / 4 ', 'Partner system': 'ACOL', 'Avg rating': '8.0', Countdown: '03:50m' },
  { Table: '#3', Players: '3 / 4 ', 'Partner system': '2-1', 'Avg rating': '6.0', Countdown: '02:50m' },
  { Table: '#4', Players: '3 / 4 ', 'Partner system': '5cards high', 'Avg rating': '8.5', Countdown: '01:45m' },
  { Table: '#5', Players: '2 / 4 ', 'Partner system': '5cards high', 'Avg rating': '6.5', Countdown: '01:30m' },
  { Table: '#6', Players: '1 / 4 ', 'Partner system': 'NAYC', 'Avg rating': '6.5', Countdown: '02:05m' },
  { Table: '#7', Players: '3 / 4 ', 'Partner system': 'NAYC', 'Avg rating': '5.5', Countdown: '01:15m' },
  { Table: '#8', Players: '3 / 4 ', 'Partner system': '2-1', 'Avg rating': '7.5', Countdown: '03:50m' },
]
</script>

<template>
  <router-link to="/multiplayer-table" custom v-slot="{ navigate }">
    <button class="btn back" @click="navigate" role="link">BACK</button>
  </router-link>
  <div class="row">
    <div class="col-8">
      <JoinGameGrid :data="gridData" :columns="gridColumns" />
    </div>
    <div class="col-1">
      <GridButtons :number="gridData.length" :text="'Join'" :color="'blue'"/>
    </div>
  </div>
</template>

<style scoped>
div {
  margin-left: 0;
  margin-right: 0;
  padding-left: 0;
  padding-right: 0;
}

.back {
  border: 3px solid;
  margin-left: 10px;
}
</style>