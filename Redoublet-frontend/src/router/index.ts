import { createRouter, createWebHistory } from "vue-router";
import type { RouteRecordRaw } from "vue-router";
import LandingView from "../views/Home/LandingView.vue";
import MenuView from "../views/Home/PlayerHomeView.vue";
import LoginView from "../views/Home/LoginView.vue";
import CreateAccountView from "../views/Home/CreateAccountView.vue";
import GameView from "../views/GameView.vue";

import {routes as robotRoutes} from "./robotRoutes";
import {routes as onlineMultiplayerRoutes} from "./onlineMultiplayerRoutes";
import {routes as playedGamesRoutes} from "./playedGamesRoutes";

const routes: Array<RouteRecordRaw> = [
  {
    path: "/",
    name: "home",
    component: LandingView,
  },
  {
    path: "/menu",
    name: "menu",
    component: MenuView,
  },
  {
    path: "/login",
    name: "login",
    component: LoginView,
  },    
  {
    path: "/create-account",
    name: "create account",
    component: CreateAccountView,
  },
  {
    path: "/game",
    component: GameView,
  },
]

const allRoutes = routes.concat(robotRoutes, onlineMultiplayerRoutes, playedGamesRoutes);


const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: allRoutes,
});

export default router;
