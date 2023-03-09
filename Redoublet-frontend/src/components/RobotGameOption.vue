<script lang="ts">
export default {
  data() {
  	return {
	    toggle: false
  	}
	}
}
</script>

<template>
<div class="container mt-5">
    <div>
        <router-link to="/game" custom v-slot="{ navigate }">
            <button class="mb-4" @click="navigate" role="link">PLAY ALONE</button>
        </router-link>
    </div>
    <div>
        <button @click="toggle = true">INVITE PARTNER</button>
    </div>

    <div class="search mt-4" v-show="toggle">
        <h3>Partner search</h3>
        <form>
            <input class="form-control" type="name" placeholder="Username">
            <br>
            <router-link to="/game" custom v-slot="{ navigate }">
                <button @click="navigate" role="link">Ask to join</button>
            </router-link>
        </form>
    </div>
</div>
</template>

<style scoped>

.container {
    width: 30%;
    left: 35%;
}

button{
    width: 100%;
    background-color: #00368C;
    border: 1px white solid;
    color: white;
    font-family:'Times New Roman', Times, serif;
    font-weight: 600;
    padding-top: 14px;
    padding-bottom: 14px;
    font-size: 20px;
}

.search {
    background-color: black;
    padding-bottom: 20px;
}

.search button {
    width: 80%;
    margin-left: 10%;
    font-family: Arial, Helvetica, sans-serif;
    font-weight: 600;
    padding-top: 5px;
    padding-bottom: 5px;
    font-size: 16px;
}

input {
    width: 80%;
    margin-left: 10%;
}

h3 {
    color: white;
    text-align: center;
    font-size: 24px;
}

</style>