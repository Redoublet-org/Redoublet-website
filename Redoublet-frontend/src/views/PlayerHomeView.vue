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
    <div class="container">
      <div class="row">
        <div class="col-2">
          <SettingsBox />
        </div>
        <div class="col-2">
          <PlayerRankBox />
        </div>
      </div>
      <div class="row content">
        <div class="col-4">
          <PlayRobotBox />
        </div>
        <div class="col-4">
          <MultiplayerBox />
        </div>
        <div class="col-4">
          <AnalysisBox />
        </div>
      </div>
    </div>
  </main>
</template>

<style scope>
.content {
  margin-top: 100px;
}
</style>