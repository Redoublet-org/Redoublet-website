<script>
var week = new Date()
var day = week.getDay()
var conversion = (7-day) * 60 * 60 * 24 * 1000 //find amount of time between today's date and sunday in ms
var time = week.getTime()
var v = time+conversion
week.setTime(v)

var now = new Date()

export default {
  data() {
    return {
      weekDate: week.getDate() + '/' + (week.getMonth()+1) + ' 23:59h',
      today: now.getDate() + '/' + (now.getMonth()+1) + ' 23:59h'
    }
  }
}
</script>

<template>
  <div>
    <h1>DAILY COMPETITION</h1>
    <br>
    <router-link to="/daily-competition" custom v-slot="{ navigate }">
      <button  @click="navigate" role="link"><h1>PLAY</h1>(Deadline: {{today}})</button>
    </router-link>
  </div>
  <div>
    <h1>WEEKLY COMPETITION</h1>
    <br>
    <router-link to="/weekly-competition" custom v-slot="{ navigate }">
      <button  @click="navigate" role="link"><h1>PLAY</h1>(Deadline: {{weekDate}})</button>
    </router-link>
  </div>
</template>