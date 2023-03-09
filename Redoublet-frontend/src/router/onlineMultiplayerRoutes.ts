import type { RouteRecordRaw } from 'vue-router';
import MultiplayerTableView from "../views/Multiplayer/MultiplayerTableView.vue";
import MultiplayerTableJoinView from "../views/Multiplayer/MultiplayerTableJoinView.vue";
import MultiplayerTableSetupView from "../views/Multiplayer/MultiplayerTableSetupView.vue";
import MultiplayerTournamentView from "../views/Multiplayer/MultiplayerTournamentView.vue";
import MultiplayerTournamentJoinView from "../views/Multiplayer/MultiplayerTournamentJoinView.vue";
import MultiplayerTournamentSetupView from "../views/Multiplayer/MultiplayerTournamentSetupView.vue";
import MultiplayerTournamentSetupLiveView from "../views/Multiplayer/MultiplayerTournamentSetupLiveView.vue";
import MultiplayerCompetitionView from "../views/Multiplayer/MultiplayerCompetitionView.vue";
import MultiplayerCompetitionJoinView from "../views/Multiplayer/MultiplayerCompetitionJoinView.vue";
import MultiplayerCompetitionSetupView from "../views/Multiplayer/MultiplayerCompetitionSetupView.vue";

export const routes: Array<RouteRecordRaw> = [
    {
        path: "/multiplayer-table",
        name: "multiplayer table",
        component: MultiplayerTableView,
    },
    {
        path: "/multiplayer-table/join",
        component: MultiplayerTableJoinView,
    },
    {
        path: "/multiplayer-table/setup",
        component: MultiplayerTableSetupView,
    },
    {
        path: "/multiplayer-tournaments",
        name: "multiplayer tournaments",
        component: MultiplayerTournamentView,
    },
    {
        path: "/multiplayer-tournaments/join",
        component: MultiplayerTournamentJoinView,
    },
    {
        path: "/multiplayer-tournaments/setup",
        component: MultiplayerTournamentSetupView,
    },
    {
        path: "/multiplayer-tournaments/setup-live",
        component: MultiplayerTournamentSetupLiveView,
    },
    {
        path: "/multiplayer-competitions",
        name: "multiplayer competitions",
        component: MultiplayerCompetitionView,
    },
    {
        path: "/multiplayer-competitions/join",
        component: MultiplayerCompetitionJoinView,
    },
    {
        path: "/multiplayer-competitions/setup",
        component: MultiplayerCompetitionSetupView,
    },
];