using Sprache;
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
        public void IdentifyTest()
        {
            string[] pbn = File.ReadAllLines(@"C:\Users\dinab\Desktop\Boeken\Year 3\SP\hi.pbn");
            string input = "%hoi";

            foreach (string s in pbn)
            {
                (string id, string val) = Final.Parse(s);
                if (id == "comment") continue;
                data.Add(id, val);
                //Console.WriteLine(Final.Parse(s));
            }

            //Console.WriteLine(Final.Parse("[North \"\"]"));

            gameState = new GameState();


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

            gameState.Dealer = Direction(data["Dealer"]);

            string[] deal = data["Deal"].Split(' ', ':');
            string currHand = deal[0];
            Player currPlayer = findPlayer(currHand);

            for (int i = 1; i < deal.Length; i++)
            {
                string[] cardSet = deal[i].Split('.');
                setCards(currPlayer, cardSet);
                currHand = nextHand(currHand);
                currPlayer = findPlayer(currHand);
            }


        }

        static Parser<(String, String)> Tags =
            from start in Parse.Char('[')
            from id in Parse.Letter.AtLeastOnce().Text().Token()
            from s in Parse.Char('"')
            from val in Parse.CharExcept('"').Many().Text().Token()
            select (id, val);

        static CommentParser Comment = new CommentParser("%", "{", "}", "\r\n");

        static Parser<(String, String)> Commented =
            from val in Comment.AnyComment
            select ("comment", val);

        static Parser<(String, String)> WhiteLine =
            from val in Parse.String("")
            select ("comment", "");

        //TODO: Chain operation voor meerdere games
        public Parser<(String, String)> Final =
            Tags.Or(Commented).Or(WhiteLine);

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
                        Value = c,
                        Face = currFace
                    };
                    //Console.WriteLine(c + currFace.ToString());
                    cards.Add(card);
                }
                currFace = nextFace(currFace);
            }

            p.Cards = cards;
        }

    }
}