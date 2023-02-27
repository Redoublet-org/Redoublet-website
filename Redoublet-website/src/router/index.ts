import { createRouter, createWebHistory } from "vue-router";
import LandingView from "../views/LandingView.vue";
import OnlineMultiplayerView from "../views/OnlineMultiplayerView.vue";

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
      component: OnlineMultiplayerView,
    },
    {
      path: "/multiplayer-tournaments",
      name: "multiplayer tournaments",
    },
    {
      path: "/multiplayer-competitions",
      name: "multiplayer competitions",
    },
  ],
});

export default router;
