import type { RouteRecordRaw } from 'vue-router';
import PlayedGamesView from "../views/PlayedGames/PlayedGamesView.vue";

export const routes: Array<RouteRecordRaw> = [
    {
        path: "/overview",
        component: PlayedGamesView,
    },
]