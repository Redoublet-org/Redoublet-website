import { createRouter, createWebHistory } from "vue-router";
import LandingView from "../views/LandingView.vue";

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
      path: "/competition",
      name: "competition",
      component: () => import("../views/PickCompetition.vue")
    }
  ],
});

export default router;
