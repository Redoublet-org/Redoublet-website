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

        public List<Trick> Tricks { get; set; }
    }

    public class Player
    {
        public string Name { get; set; }

        public List<Card> Cards { get; set; }

        public bool Vulnerable { get; set; }
    }

    public class Card
    {
        public int Value { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Suit Suit { get; set; }
    }

    public class Trick
    {
        public Card[] Cards { get; set; }

        public Side Winner { get; set; }
    }

    public enum Side
    {
        North,
        East,
        South,
        West,
    }

    public enum Suit
    {
        Diamond,
        Heart,
        Spade,
        Club,
    }
}
