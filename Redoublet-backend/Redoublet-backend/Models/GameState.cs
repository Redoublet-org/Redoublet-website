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
        public Contract(int oddTricks, Face denominator, Risk contractRisk)
        {
            OddTricks = oddTricks;
            Denominator = denominator;
            ContractRisk = contractRisk;
        }

        public Contract() { }

        public int OddTricks { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Face Denominator { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Risk ContractRisk { get; set; }

        public Contract Copy()
        {
            return new Contract(this.OddTricks, this.Denominator, this.ContractRisk);
        }
    }

    public class Auction
    {
        public Auction(Contract north, Contract east, Contract south, Contract west)
        {
            North = north;
            East = east;
            South = south;
            West = west;
        }

        public Auction() { }

        public Contract North { get; set; }

        public Contract East { get; set; }

        public Contract South { get; set; }

        public Contract West { get; set; }

        public void BidContract(int tricks, Face d, string side)
        {
            switch (side)
            {
                case "N":
                    North = new Contract(tricks, d, Risk.Undoubled);
                    break;
                case "E":
                    East = new Contract(tricks, d, Risk.Undoubled);
                    break;
                case "S":
                    South = new Contract(tricks, d, Risk.Undoubled);
                    break;
                case "W":
                    West = new Contract(tricks, d, Risk.Undoubled);
                    break;
                default: break;
            }
        }

        public void Double(string side, Risk d)
        {
            switch (side)
            {
                case "N":
                    North = West.Copy();
                    North.ContractRisk = d;
                    break;
                case "E":
                    East = North.Copy();
                    East.ContractRisk = d;
                    break;
                case "S":
                    South = East.Copy();
                    South.ContractRisk = d;
                    break;
                case "W":
                    West = South.Copy();
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
                    North = null;
                    break;
                case "E":
                    East = null;
                    break;
                case "S":
                    South = null;
                    break;
                case "W":
                    West = null;
                    break;
                default: break;
            }
        }

        public Auction Copy()
        {
            return new Auction(North?.Copy(), East?.Copy(), South?.Copy(), West?.Copy());
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
