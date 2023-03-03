<script>
export default {
  data() {
  	return {
	    toggle: false
  	}
	}
}
</script>

<template>
<div>
    <router-link to="/competition" custom v-slot="{ navigate }">
        <button @click="navigate" role="link">PLAY ALONE</button>
    </router-link>
</div>
<div>
    <button @click="toggle = true">INVITE PARTNER</button>
</div>

<div v-show="toggle">
    <h1>Partner Search</h1>
    <form>
        <input type="name" placeholder="Username">
        <br>
        <router-link to="/competition" custom v-slot="{ navigate }">
            <button  @click="navigate" role="link">Ask to join</button>
        </router-link>
    </form>
</div>
</template>