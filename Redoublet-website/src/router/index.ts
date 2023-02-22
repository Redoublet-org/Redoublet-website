import { createRouter, createWebHistory } from "vue-router";
import HomeView from "../views/HomeView.vue";

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: "/",
      name: "home",
      component: HomeView,
    },
    {
      path: "/menu",
      name: "menu",
      component: () => import("../views/PlayerHomeView.vue"),
    },
    {
      path: "/robot-random-board",
      name: "robot random board",
    },
    {
      path: "/robot-competition",
      name: "robot competition",
    }
  ],
});

export default router;
