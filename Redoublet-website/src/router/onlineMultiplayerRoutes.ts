import MultiplayerTableView from "../views/MultiplayerTableView.vue";
import MultiplayerTableJoinView from "../views/MultiplayerTableJoinView.vue";
import MultiplayerTableSetupView from "../views/MultiplayerTableSetupView.vue";
import MultiplayerTournamentView from "../views/MultiplayerTournamentView.vue";
import MultiplayerTournamentJoinView from "../views/MultiplayerTournamentJoinView.vue";
import MultiplayerTournamentSetupView from "../views/MultiplayerTournamentSetupView.vue";
import MultiplayerTournamentSetupLiveView from "../views/MultiplayerTournamentSetupLiveView.vue";
import MultiplayerCompetitionView from "../views/MultiplayerCompetitionView.vue";
import MultiplayerCompetitionJoinView from "../views/MultiplayerCompetitionJoinView.vue";
import MultiplayerCompetitionSetupView from "../views/MultiplayerCompetitionSetupView.vue";

const multiplayerRoutes = [
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