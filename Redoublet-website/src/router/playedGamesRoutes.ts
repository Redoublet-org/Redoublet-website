import type { RouteRecordRaw } from 'vue-router';
import PlayedGamesView from "../views/PlayedGamesView.vue";

export const routes: Array<RouteRecordRaw> = [
    {
        path: "/overview",
        component: PlayedGamesView,
    },
]