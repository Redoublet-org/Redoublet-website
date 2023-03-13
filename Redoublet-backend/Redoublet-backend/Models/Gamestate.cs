using Redoublet.Backend.Services;
using System.Text.Json.Serialization;

namespace Redoublet.Backend.Models
{
    public class Gamestate
    {
        public Player[] Players { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Side Dealer { get; set; }

        public int Round { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Suit Trump { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Side CurrentPlayer { get; set; }

        public Bid? HighestBid { get; set; }

        public List<Bid> BidHistory { get; set; }

        public List<Trick> Tricks { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Phase CurrentPhase { get; set; }

        public void NextPlayer()
        {
            // Decide the next player
            int currentPlayer = (int)this.CurrentPlayer;
            int nextPlayer = (currentPlayer + 1) % 4;

            this.CurrentPlayer = (Side)nextPlayer;
        }

        public enum Phase
        {
            Bidding,
            Tricks,
            Points,
        }
    }
}
