import type { Card } from "./Icard";

export interface Player {
    name: string;
    cards: Card[];
    vulnerable: boolean;
  }