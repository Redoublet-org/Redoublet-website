using Redoublet.Backend.Models;
using System.Security.Cryptography;

namespace Redoublet.Backend.Services
{
    public class BiddingService
    {
        public static Gamestate Bid(Gamestate gamestate, Bid bid)
        {
            // Verify that bid is valid
            if (bid.Amount <= 0 || bid.Amount > 7)
            {
                return gamestate;
            }

            // Verify that bid is higher than highest current bid
            if (gamestate.HighestBid == null                                                                        // First bid
                || bid.Amount > gamestate.HighestBid.Amount                                                         // Higher amount
                || (bid.Amount == gamestate.HighestBid.Amount && (int)bid.Suit > (int)gamestate.HighestBid.Suit))   // Same amount, higher suit
            {
                gamestate.HighestBid = bid;
                gamestate.BidHistory.Add(bid);
            }

            gamestate.NextPlayer();

            return gamestate;
        }

        public static Gamestate Pass(Gamestate gamestate)
        {
            gamestate.BidHistory.Add(new Bid()
            {
                Amount = -1,
                Suit = BiddingSuit.Pass,
            });


            gamestate.NextPlayer();

            bool biddingFinished = gamestate.BidHistory
                .TakeLast(3)
                .All(bid => (int)bid.Suit == -1) 
                && gamestate.BidHistory.Count >= 3;

            if (biddingFinished)
            {
                gamestate.CurrentPhase = Gamestate.Phase.Tricks;
            }

            return gamestate;
        }
    }
}
