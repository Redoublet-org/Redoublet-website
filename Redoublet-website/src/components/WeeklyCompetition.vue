<script>
var now = new Date()
var day = now.getDay()
var conversion = (7-day) * 60 * 60 * 24 * 1000
var time = now.getTime()
var v = time+conversion
now.setTime(v)
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
    <h1>WEEKLY COMPETITION</h1>
    <br>
    <router-link to="/weekly-competition" custom v-slot="{ navigate }">
      <button  @click="navigate" role="link"><h1>PLAY</h1>(Deadline: {{ dateDay + '/' + dateMonth + ' 23:59h'}})</button>
    </router-link>
  </div>
</template>