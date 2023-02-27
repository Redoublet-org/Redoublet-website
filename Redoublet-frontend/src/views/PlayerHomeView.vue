<script setup lang="ts">
import PlayRobotBox from "../components/PlayRobotBox.vue";
import MultiplayerBox from "../components/MultiplayerBox.vue";
import AnalysisBox from "../components/AnalysisBox.vue";
import SettingsBox from "../components/SettingsBox.vue";
import PlayerRankBox from "../components/PlayerRankBox.vue";
import TestBoardBox from "../components/TestBoardBox.vue";

</script>

<template>
  <main>
    <SettingsBox />
    <PlayerRankBox />
    <PlayRobotBox />
    <MultiplayerBox />
    <AnalysisBox />
    <TestBoardBox />
  </main>
</template>
