<script setup lang="ts">

import { ref } from 'vue'

interface Gamestate {
  players: Player[];
  dealer: string;
  round: number;
  trump: string;
  currentPlayer: string;
  highestBid: Bid | null;
  bidHistory: Bid[];
  tricks: Trick[];
  currentPhase: string;
}

interface Player {
  name: string;
  cards: Card[];
  vulnerable: boolean;
}

interface Bid {
  type: string;
  bid: CardBid | null;
}

interface Card {
  suit: string;
  rank: number;
}

interface CardBid {
  value: number;
  suit: number;
}

interface Trick {
  cards: Card[];
  winner: number;
}

let currentGamestate = ref<Gamestate | null>(null);
let bidSuit = ref(0);
let bidAmount = ref(0);
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
    currentGamestate.value = JSONresult
    isResultReady.value = true
}

const bid = async () => {
    const response = await fetch('http://localhost:5000/api/Bid', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            gamestate: currentGamestate.value,
            bid: {
                Suit: bidSuit.value,
                Amount: bidAmount.value,
            }
            
        })
    })

    const JSONresult = await response.json()
    currentGamestate.value = JSONresult
    isResultReady.value = true
}

const pass = async () => {
    const response = await fetch('http://localhost:5000/api/Bid', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            gamestate: currentGamestate.value,
            bid: {
                Suit: -1,
                Amount: 1,
            }
            
        })
    })

    const JSONresult = await response.json()
    currentGamestate.value = JSONresult
    isResultReady.value = true
}

</script>

<template>
    
    <div class="row">
        <div class="col-4">
            <div>
                <button @click="startGame">Shuffle cards</button>
            </div>

            <div v-if="isResultReady">
                <div v-for="(value, key) in currentGamestate">
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
        </div>

        <div class="col-4">
            <div>
                <label for="suit">Suit</label>
                <input type="number" id="suit" name="suit" v-model="bidSuit" placeholder="Suit">
                <br>
                <label for="amount">Amount</label>
                <input type="number" id="amount" name="amount" v-model="bidAmount" placeholder="Amount">
                <br>
                <button @click="bid">Bid</button>
            </div>

            <div>
                <button @click="pass">Pass</button>
            </div>

            <div v-for="(value, key) in currentGamestate">
                <div v-if="key === 'highestBid'">
                    <p>Highest bid</p>
                    <span v-for="(property, key) in value">
                        <span v-if="key === 'suit'">
                            {{ property }}
                        </span>

                        <span v-if="key === 'amount'">
                            {{ property }}
                        </span>
                    </span>
                </div>

                <div v-if="key === 'bidHistory'">
                    <p>Bidding history</p>
                    <ul>
                        <div v-for="card in value">
                            <li>
                                <span v-for="(property, key) in card">
                                    <span v-if="key === 'suit'">
                                        {{ property }}
                                    </span>

                                    <span v-if="key === 'amount'">
                                        <span v-if="property != -1">
                                            {{ property }}
                                        </span>
                                    </span>
                                </span>
                            </li>
                        </div>
                    </ul>
                </div>
                
                
                <div v-if="key === 'currentPhase'">
                    <p>Current phase = {{ value }}</p>
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