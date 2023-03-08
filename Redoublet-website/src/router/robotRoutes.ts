import RobotRandomBoardView from "../views/RobotRandomBoard.vue";
import RobotCompetitionView from "../views/RobotCompetition.vue";
import CompetitionView from "../views/PickCompetitionView.vue";

const robotRoutes = [
    {
        path: "/robot-random-board",
        name: "robot random board",
        component: RobotRandomBoardView
    },
    {
        path: "/robot-competition",
        name: "robot competition",
        component: RobotCompetitionView
    },
    {
        path: "/competition",
        name: "competition",
        component: CompetitionView
    }
];