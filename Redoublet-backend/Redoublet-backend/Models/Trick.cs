namespace Redoublet.Backend.Models
{
    public class Trick
    {
        public List<Card> Cards { get; set; }

        public Side? Winner { get; set; }
    }
}
