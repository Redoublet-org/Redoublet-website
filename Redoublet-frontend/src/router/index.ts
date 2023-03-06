import { createRouter, createWebHistory } from "vue-router";
import LandingView from "../views/LandingView.vue";
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
import PlayedGamesView from "../views/PlayedGamesView.vue"

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: "/",
      name: "home",
      component: LandingView,
    },
    {
      path: "/menu",
      name: "menu",
      component: () => import("../views/PlayerHomeView.vue"),
    },
    {
      path: "/login",
      name: "login",
      component: () => import("../views/LoginView.vue"),
    },    
    {
      path: "/create-account",
      name: "create account",
      component: () => import("../views/CreateAccountView.vue"),
    },
    {
      path: "/robot-random-board",
      name: "robot random board",
      component: () => import("../views/RobotRandomBoard.vue")
    },
    {
      path: "/robot-competition",
      name: "robot competition",
      component: () => import("../views/RobotCompetition.vue")
    },
    {
      path: "/test-board",
      name: "test board",
      component: () => import("../views/TestBoardView.vue")
    },
    {
      path: "/competition",
      name: "competition",
      component: () => import("../views/PickCompetition.vue")
    },
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
    {
      path: "/overview",
      component: PlayedGamesView,
    },
  ],
});

export default router;
