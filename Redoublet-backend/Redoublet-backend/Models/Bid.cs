using System.Text.Json.Serialization;

namespace Redoublet.Backend.Models
{
    public class Bid
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public BiddingSuit Suit { get; set; }

        public int Amount { get; set; }
    }

    public enum BiddingSuit
    {
        Pass = -1,
        Club = 1,
        Diamond = 2,
        Heart = 3,
        Spade = 4,
        NoTrump = 5,
    }
}
