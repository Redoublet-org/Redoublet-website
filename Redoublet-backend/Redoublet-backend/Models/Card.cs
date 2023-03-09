using System.Text.Json.Serialization;

namespace Redoublet.Backend.Models
{
    public class Card
    {
        public CardValue Value { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Suit Suit { get; set; }
    }

    public enum Suit
    {
        Diamond,
        Heart,
        Spade,
        Club,
    }

    public enum CardValue
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14,
    }
}
