<script setup lang="ts">
import JoinGameGrid from "../../components/DefaultGrid.vue";
import GridButtons from "../../components/GridButtons.vue";

const gridColumns = ['Game', 'Opponent', 'Contract', 'Result', 'SCORING', 'DATE', 'TIME'];
const gridData = [
  { Game: 'Online', Opponent: '[name]', Contract: '1NT', Result: '+1', SCORING: 'IMP / MP (%)', DATE: '19/02', TIME: '11.00' },
  { Game: 'Online', Opponent: '[name]', Contract: '3♥', Result: '+1', SCORING: 'IMP / MP (%)', DATE: '19/02', TIME: '10.55' },
  { Game: 'Online', Opponent: '[name]', Contract: '2♦', Result: '-', SCORING: 'IMP / MP (%)', DATE: '19/02', TIME: '10.50' },
  { Game: 'Online', Opponent: '[name]', Contract: '2NT', Result: '-2', SCORING: 'IMP / MP (%)', DATE: '19/02', TIME: '10.46' },
  { Game: 'Online', Opponent: '[name]', Contract: '4NT', Result: '-2', SCORING: 'IMP / MP (%)', DATE: '19/02', TIME: '10.40' },
  { Game: 'Physical', Opponent: '[name]', Contract: '4♠', Result: '+1', SCORING: 'IMP / MP (%)', DATE: '16/02', TIME: '20.00' },
  { Game: 'Physical', Opponent: '[name]', Contract: '3♥', Result: '+1', SCORING: 'IMP / MP (%)', DATE: '16/02', TIME: '19.55' },
  { Game: 'Physical', Opponent: '[name]', Contract: '4♦', Result: '-1', SCORING: 'IMP / MP (%)', DATE: '16/02', TIME: '19.50' },
];
</script>

<template>
  <router-link to="/menu" custom v-slot="{ navigate }">
    <button class="btn back" @click="navigate" role="link">BACK</button>
  </router-link>
  <div class="row">
    <div class="col-8">
      <JoinGameGrid :data="gridData" :columns="gridColumns" />
    </div>
    <div class="col-1">
      <GridButtons :number="gridData.length" :text="'Analyse'" :color="'blue'" />
    </div>
    <div class="col-1">
      <GridButtons :number="gridData.length" :text="'Replay'" :color="'orange'" />
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