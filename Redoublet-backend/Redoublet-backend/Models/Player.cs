namespace Redoublet.Backend.Models
{
    public class Player
    {
        public string Name { get; set; }

        public List<Card> Cards { get; set; }

        public bool Vulnerable { get; set; }
    }

    public enum Side
    {
        North,
        East,
        South,
        West,
    }
}
