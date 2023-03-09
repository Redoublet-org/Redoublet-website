<script setup lang="ts">

import { ref } from 'vue'
import type { GameResult } from '../interfaces/IGameResult';
import type { Player } from '../interfaces/IPlayer';
import type { Card } from '../interfaces/Icard';
import type { Trick } from '../interfaces/ITrick';

let result = ref<GameResult | null>(null);

let isResultReady = ref(false)

const startGame = async () => {
    const response = await fetch('http://localhost:5000/api/StartGame', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            NameNorth: 'Speler 1',
            NameEast: 'Speler 2',
            NameSouth: 'Speler 3',
            NameWest: 'Speler 4',
        })
    })

    const JSONresult = await response.json()
    result.value = JSONresult
    isResultReady.value = true
}

</script>

<template>
    <div>
        <button @click="startGame">Shuffle cards</button>
    </div>

    <div v-if="isResultReady">
        <div v-for="(value, key) in result">
            
            <div v-if="key === 'currentPlayer'"> 
                <p>{{ value }} is aan de beurt</p>
            </div>
            
            <div v-if="key === 'players'">
                <div v-for="player in value">
                    <ul>
                        <div v-for="(value, key) in player">
                            <div v-if="key === 'name'">
                                <h3>
                                    <b>{{ value }}</b>
                                </h3>
                            </div>

                            <div v-if="key === 'cards'">
                                <div v-for="card in value">
                                    <li>
                                        <span v-for="(property, key) in card">
                                            <span v-if="key === 'suit'">
                                                {{ property }}
                                            </span>

                                            <span v-if="key === 'value'">
                                                {{ property }}
                                            </span>
                                        </span>
                                    </li>
                                </div>
                            </div>
                        </div>
                    </ul>
                    
                    <br>
                </div>
            </div>
        </div>  
    </div>

</template>

<style>
span {
    margin: 0 0.15rem 0 0
}

</style>