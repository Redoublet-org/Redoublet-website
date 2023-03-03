using Microsoft.AspNetCore.Routing;
using System.Collections;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Redoublet.Backend.Models
{
    public class GameState
    {

        public List<Trick> PlayedTricks = new List<Trick>();

        public List<Auction> EntireAuction = new List<Auction>();

        public Trick[] JSONTricks { get { return PlayedTricks.ToArray(); } }

        public Auction[] JSONAuction { get { return EntireAuction.ToArray(); } }

        public Player[] Players { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Side Dealer { get; set; }

        public int Round { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Face Trump { get; set; }

        public string Scoring { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Side Declarer { get; set; }

        public Contract Contract { get; set; }

        public int Result { get; set; }

    }

    public enum Side
    {
        North,
        East,
        South,
        West,
        Pass
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
        NoTrump
    }

    public enum Risk
    {
        Undoubled,
        Doubled,
        Redoubled
    }

    public class Player
    {
        public string Name { get; set; }

        public List<Card> Cards { get; set; }

        public bool Vulnerable { get; set; }
    }

    public class Contract
    {
        public int OddTricks { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Face Denominator { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Risk ContractRisk { get; set; }
    }

    public class Auction
    {
        public Contract North { get; set; }

        public Contract East { get; set; }

        public Contract South { get; set; }

        public Contract West { get; set; }

        public void BidContract(int tricks, Face d, string side)
        {
            switch (side)
            {
                case "N":
                    North = new Contract { OddTricks = tricks, Denominator = d, ContractRisk = Risk.Undoubled };
                    break;
                case "E":
                    East = new Contract { OddTricks = tricks, Denominator = d, ContractRisk = Risk.Undoubled };
                    break;
                case "S":
                    South = new Contract { OddTricks = tricks, Denominator = d, ContractRisk = Risk.Undoubled };
                    break;
                case "W":
                    West = new Contract { OddTricks = tricks, Denominator = d, ContractRisk = Risk.Undoubled };
                    break;
                default: break;
            }
        }

        public void Double(string side, Risk d)
        {
            switch (side)
            {
                case "N":
                    North = West;
                    North.ContractRisk = d;
                    break;
                case "E":
                    East = North;
                    East.ContractRisk = d;
                    break;
                case "S":
                    South = East;
                    South.ContractRisk = d;
                    break;
                case "W":
                    West = South;
                    West.ContractRisk = d;
                    break;
                default: break;
            }
        }

        public void Pass(string side)
        {
            switch (side)
            {
                case "N":
                    North = new Contract();
                    break;
                case "E":
                    East = new Contract();
                    break;
                case "S":
                    South = new Contract();
                    break;
                case "W":
                    West = new Contract();
                    break;
                default: break;
            }
        }
    }

    public class Trick
    {
        public Card North { get; set; }

        public Card East { get; set; }

        public Card South { get; set; }

        public Card West { get; set; }

        public List<Card> GetTrick() {
            return new List<Card>() { North, East, South, West};
        }

        public void SetCard(Card c, string side)
        {
            switch (side)
            {
                case "N":
                    North = c;
                    break;
                case "E":
                    East = c;
                    break;
                case "S":
                    South = c;
                    break;
                case "W":
                    West = c;
                    break;
                default: break;
            }
        }
    }
}
