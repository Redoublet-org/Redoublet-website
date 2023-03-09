import type { Card } from "./Icard";

export interface Trick {
    cards: Card[];
    winner: number;
  }