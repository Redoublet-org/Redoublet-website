import { createRouter, createWebHistory } from "vue-router";
import LandingView from "../views/LandingView.vue";
import MultiplayerTableView from "../views/MultiplayerTableView.vue";
import MultiplayerTournamentView from "../views/MultiplayerTournamentView.vue";
import MultiplayerCompetitionView from "../views/MultiplayerCompetitionView.vue";

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
    },
    {
      path: "/robot-competition",
      name: "robot competition",
    },
    {
      path: "/multiplayer-table",
      name: "multiplayer table",
      component: MultiplayerTableView,
      children: [
        {
          path: "join",
          name: "join existing table",
          component: MultiplayerTableView,
        },
        {
          path: "setup",
          name: "setup table",
          component: MultiplayerTableView,
        },
      ],
    },
    {
      path: "/multiplayer-tournaments",
      name: "multiplayer tournaments",
      component: MultiplayerTournamentView,
      children: [
        {
          path: "join",
          name: "join tournament",
          component: MultiplayerTournamentView,
        },
        {
          path: "setup",
          name: "setup online tournament",
          component: MultiplayerTournamentView,
        },
        {
          path: "setup-live",
          name: "setup live tournament",
          component: MultiplayerTournamentView,
        },
      ],
    },
    {
      path: "/multiplayer-competitions",
      name: "multiplayer competitions",
      component: MultiplayerCompetitionView,
      children: [
        {
          path: "join",
          name: "join competition",
          component: MultiplayerCompetitionView,
        },
        {
          path: "setup",
          name: "setup competition",
          component: MultiplayerCompetitionView,
        },
      ],
    },
  ],
});

export default router;
