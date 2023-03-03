using Sprache;
using System.Collections.Generic;
using System.Data.Common;
using System.Text.Json.Serialization;

namespace Redoublet.Backend.Models
{
    public class PBNParser
    {
        GameState gameState;
        Dictionary<string, string> data = new Dictionary<string, string>();
        Player pw = new Player();
        Player pn = new Player();
        Player pe = new Player();
        Player ps = new Player();
        public GameState importPBN()
        {
            string[] pbn = File.ReadAllLines(@"C:\Users\dinab\Desktop\Boeken\Year 3\SP\hi.pbn");
            bool multiLineComment = false;
            bool play = false;
            int auctionLine = -1;
            gameState = new GameState();

            foreach (string s in pbn)
            {
                (string id, string val) = Final.Parse(s);
                if (val == "MultiLineComment") multiLineComment = !multiLineComment;
                if (multiLineComment) continue;
                if (id == "comment") continue;
                if (id == "Note") continue;
                if (id == "Play") play = true;
                if (play && id == "round")
                {
                    Trick trick = new Trick();
                    string turn = "N";
                    foreach(string v in val.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        if (v[0] == '=' || v[0] == '!' || v[0] == '?') continue;
                        if (v[0] == '-' || v[0] == '+')
                        {
                            turn = nextHand(turn);
                            continue;
                        }
                        Card card = new Card() { Face = FindFace(v[0].ToString()), Value = CardNumericValue(v[1])};
                        trick.SetCard(card, turn);
                        turn = nextHand(turn);
                    }
                    gameState.PlayedTricks.Add(trick);
                    continue;
                }
                else if (id == "round")
                {
                    string turn = data["Auction"];
                    Auction auction;
                    if (auctionLine >= 0) auction = gameState.EntireAuction[auctionLine].Copy();
                    else auction = new Auction();

                    foreach (string v in val.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        Console.WriteLine(v);
                        if (v[0] == '=' || v[0] == '!' || v[0] == '?') continue;
                        if (v[0] == 'X') auction.Double(turn, FindRisk(v));
                        else if (v[0] == 'P') auction.Pass(turn);
                        else auction.BidContract((int)Char.GetNumericValue(v[0]), FindFace(v[1..].ToString()), turn);

                        turn = nextHand(turn);
                    }
                    gameState.EntireAuction.Add(auction);
                    auctionLine++;
                    continue;
                }
                Console.WriteLine(id);
                data.Add(id, val);
            }

            //Set player name and vulnerability
            pw.Name = data["West"];
            pw.Vulnerable = ((new[] { "EW", "Both", "All" }).Contains(data["Vulnerable"], StringComparer.OrdinalIgnoreCase)) ? true : false;
            
            pn.Name = data["North"];
            pn.Vulnerable = ((new[] { "NS", "Both", "All" }).Contains(data["Vulnerable"], StringComparer.OrdinalIgnoreCase)) ? true : false;
            
            pe.Name = data["East"];
            pe.Vulnerable = ((new[] { "EW", "Both", "All" }).Contains(data["Vulnerable"], StringComparer.OrdinalIgnoreCase)) ? true : false;
            
            ps.Name = data["South"];
            ps.Vulnerable = ((new[] { "NS", "Both", "All" }).Contains(data["Vulnerable"], StringComparer.OrdinalIgnoreCase)) ? true : false;

            Player[] players = new Player[4] { pw, pn, pe, ps };
            gameState.Players = players;

            //Set dealer
            gameState.Dealer = Direction(data["Dealer"]);

            //Set deal, starting from the dealer in a clockwise manner
            //Splits deal tag into the 4 players
            string[] deal = data["Deal"].Split(' ', ':');
            string currHand = deal[0];
            Player currPlayer = findPlayer(currHand);

            //Adds players current cards
            for (int i = 1; i < deal.Length; i++)
            {
                string[] cardSet = deal[i].Split('.');
                setCards(currPlayer, cardSet);
                currHand = nextHand(currHand);
                currPlayer = findPlayer(currHand);
            }

            //Set scoring type
            gameState.Scoring = data["Scoring"];

            //Set declarer
            if (data["Declarer"][0] == '^') //irregular declarer, denk niet dat dat veel uitmaakt
                gameState.Declarer = Direction(data["Declarer"][1].ToString());
            else
                gameState.Declarer = Direction(data["Declarer"]);
            
            //Set contract; undoubled, doubled or redoubled
            Contract contract = new Contract();
            contract.OddTricks = (int)Char.GetNumericValue(data["Contract"][0]);
            contract.Denominator = FindFace(data["Contract"][1].ToString());
            contract.ContractRisk = (data["Contract"].Length < 3) ? Risk.Undoubled : FindRisk(data["Contract"][2].ToString());
            gameState.Contract = contract;

            gameState.Round = Int32.Parse(data["Board"]);

            //Vanuitgaand dat de result tag alleen 'the number of tricks won by declarer' bevat
            gameState.Result = Int32.Parse(data["Result"]);

            //TODO: Auction, begrijp ik nog niet helemaal


            return gameState;
        }

        static Parser<(String, String)> Tags =
            from start in Parse.Char('[')
            from id in Parse.Letter.AtLeastOnce().Text().Token()
            from s in Parse.Char('"')
            from val in Parse.CharExcept('"').Many().Text().Token()
            select (id, val);

        static Parser<(String, String)> SingleLineComment =
            from val in Parse.Char('%')
            from end in Parse.AnyChar.Many()
            select ("comment", "SingleLineComment");

        static Parser<(String, String)> MultiLineComment =
            from val in Parse.Char('{').Or(Parse.Char('}'))
            from end in Parse.AnyChar.Many()
            select ("comment", "MultiLineComment");

        static Parser<(String, String)> WhiteLine =
            from val in Parse.String("")
            select ("comment", "");

        static Parser<(String, String)> Incomplete =
            from val in Parse.Char('*')
            select ("incomplete", "incomplete");

        static Parser<(String, String)> Game =
            from round in Parse.CharExcept('*').AtLeastOnce().Text().Token()
            select ("round", round);

        //TODO: Chain operation voor meerdere games
        public Parser<(String, String)> Final =
            Tags.Or(SingleLineComment).Or(MultiLineComment).Or(Game).Or(WhiteLine).Or(Incomplete);
            

        public Side Direction(string s)
        {
            switch (s)
            {
                case "N":
                    return Side.North;
                case "E":
                    return Side.East;
                case "S":
                    return Side.South;
                case "W":
                    return Side.West;
                case "":
                    return Side.Pass;
                default:
                    throw new NotImplementedException();
            }
        }

        public string nextHand(string p)
        {
            switch (p)
            {
                case "N":
                    return "E";
                case "E":
                    return "S";
                case "S":
                    return "W";
                case "W":
                    return "N";
                default:
                    throw new NotImplementedException();
            }
        }

        public Face nextFace(Face f)
        {
            switch (f)
            {
                case Face.Spade:
                    return Face.Heart;
                case Face.Heart:
                    return Face.Diamond;
                case Face.Diamond:
                    return Face.Club;
                case Face.Club:
                    return Face.Club;
                default:
                    throw new NotImplementedException();
            }
        }

        public Face FindFace (string s)
        {
            switch (s)
            {
                case "S":
                    return Face.Spade;
                case "D":
                    return Face.Diamond;
                case "C":
                    return Face.Club;
                case "H":
                    return Face.Heart;
                case "NT":
                    return Face.NoTrump;
                default:
                    throw new NotImplementedException();
            }
        }

        public Risk FindRisk (string s)
        {
            switch (s)
            {
                case "":
                    return Risk.Undoubled;
                case "X":
                    return Risk.Doubled;
                case "XX":
                    return Risk.Redoubled;
                default:
                    throw new NotImplementedException();
            }
        }

        public Player findPlayer(string p)
        {
            switch (p)
            {
                case "N":
                    return pn;
                case "E":
                    return pe;
                case "S":
                    return ps;
                case "W":
                    return pw;
                default:
                    throw new NotImplementedException();
            }
        }

        public void setCards(Player p, String[] s)
        {
            Face currFace = Face.Spade;
            List<Card> cards = new List<Card>();
            //Console.WriteLine(p.Name);
            for (int i = 0; i < s.Length; i++)
            {
                foreach(char c in s[i])
                {
                    if (c == ' ') continue;
                    Card card = new Card
                    {
                        Value = CardNumericValue(c),
                        Face = currFace
                    };
                    //Console.WriteLine(c + currFace.ToString());
                    cards.Add(card);
                }
                currFace = nextFace(currFace);
            }

            p.Cards = cards;
        }

        public int CardNumericValue(char c)
        {
            switch (c)
            {
                case 'T':
                    return 10;
                case 'J':
                    return 11;
                case 'Q':
                    return 12;
                case 'K':
                    return 13;
                case 'A':
                    return 14;
                default:
                    return (int)char.GetNumericValue(c);
            }
        }

    }
}