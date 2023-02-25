using System.Text.Json.Serialization;

namespace Redoublet.Backend.Models
{
    public class GameState
    {
        public Player[] Players { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Side Dealer { get; set; }

        public int Round { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Face Trump { get; set; }
    }

    public enum Side
    {
        North,
        East,
        South,
        West,
    }

    public class Card
    {
        public int Value { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Face Face { get; set; }
    }

    public enum Face
    {
        Diamond,
        Heart,
        Spade,
        Club,
    }

    public class Player
    {
        public string Name { get; set; }

        public List<Card> Cards { get; set; }

        public bool Vulnerable { get; set; }
    }
}
