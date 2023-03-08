import { createRouter, createWebHistory } from "vue-router";
import LandingView from "../views/LandingView.vue";
import MenuView from "../views/PlayerHomeView.vue";
import LoginView from "../views/LoginView.vue";
import CreateAccountView from "../views/CreateAccountView.vue";

import * as robotRoutes from "./robotRoutes";
import * as onlineMultiplayerRoutes from "./onlineMultiplayerRoutes";
import * as playedGamesRoutes from "./playedGamesRoutes";

const homeRoutes = [
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
]

const allRoutes = homeRoutes.concat(robotRoutes, onlineMultiplayerRoutes, playedGamesRoutes);


const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: allRoutes,
});

export default router;
