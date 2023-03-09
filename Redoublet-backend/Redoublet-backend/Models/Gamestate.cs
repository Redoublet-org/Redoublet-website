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

    public enum Side
    {
        North,
        East,
        South,
        West,
    }
}
