using Redoublet.Backend.Models; 

namespace Redoublet.Backend.Services
{
    public class GameService
    {
        // Method to randomly deal 13 cards to each player in the game
        public static Gamestate DealCards(Gamestate gamestate)
        {
            // Array of all cards
            List<Card> deck = GetDeck();

            // Loop over every player
            foreach (Player player in gamestate.Players)
            {
                // Give each player 13 cards
                List<Card> cards = new List<Card>();

                Random random = new Random();

                for (int i = 0; i < 13; i++)
                {
                    int index = random.Next(deck.Count);

                    cards.Add(deck[index]);
                    deck.RemoveAt(index);
                }

                player.Cards = cards;
            }

            return gamestate;
        }

        // Method to generate a full deck of cards
        public static List<Card> GetDeck()
        {
            List<Card> deck = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (int value in Enumerable.Range(2, 13))
                {
                    deck.Add(new Card()
                    {
                        Suit = suit,
                        Value = value,
                    });
                }
            }

            return deck;
        }
    }
}
