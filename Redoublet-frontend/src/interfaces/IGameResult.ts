import type { Trick } from "./ITrick";
import type { Player } from "./IPlayer";

export interface GameResult {
    players: Player[];
    dealer: number;
    round: number;
    trump: number;
    currentPlayer: number;
    tricks: Trick[];
  }