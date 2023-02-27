<script>
var now = new Date()

export default {
  data() {
    return {
      dateDay: now.getDate(),
      dateMonth: now.getMonth()+1,
      greeting: 'hihihaha'
    }
  }
}
</script>

<template>
  <div>
    <h1>DAILY COMPETITION</h1>
    <br>
    <router-link to="/daily-competition" custom v-slot="{ navigate }">
      <button  @click="navigate" role="link"><h1>PLAY</h1>(Deadline: {{ dateDay + '/' + dateMonth + ' 23:59h'}})</button>
    </router-link>
  </div>
</template>