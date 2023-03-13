using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Redoublet.Backend.Models;
using Redoublet.Backend.Services;

namespace Redoublet.Backend.Controllers
{
    [ApiController]
    [Route("api")]
    public class BridgeGameLogic : ControllerBase
    {
        // Interface that can be used for debugging to console
        private readonly ILogger<BridgeGameLogic> _logger;
        
        public BridgeGameLogic(ILogger<BridgeGameLogic> logger)
        {
            _logger = logger;
        }

        [EnableCors("policy")]
        [HttpPost]
        [Route("StartGame")]
        public Gamestate StartGame([FromBody] StartGameRequest req)
        {
            // Initiate the game
            Gamestate gamestate = new Gamestate()
            {
                Players = new Player[]
                {
                    new Player()
                    {
                        Name = req.NameNorth,
                    },
                    new Player()
                    {
                        Name = req.NameEast,
                    },
                    new Player()
                    {
                        Name = req.NameSouth,
                    },
                    new Player()
                    {
                        Name = req.NameWest,
                    },
                },
                Dealer = Side.North,
                CurrentPlayer = Side.North,
                Round = 0,
                Tricks = new List<Trick>(),
                BidHistory = new List<Bid>(),
                CurrentPhase = Gamestate.Phase.Bidding,
            };

            gamestate = DistributeCardsService.DealCards(gamestate);

            return gamestate;
        }

        [HttpPost]
        [Route("PlayCard")]
        public Gamestate PlayCard(Gamestate gamestate, [FromQuery] Card card)
        {
            // Get the latest trick
            Trick currentTrick = gamestate.Tricks.Last();

            // Add the given card to the trick
            currentTrick.Cards[(int) gamestate.CurrentPlayer] = card;

            return gamestate;
        }

        [EnableCors("policy")]
        [HttpPost]
        [Route("Bid")]
        public Gamestate Bid([FromBody] BidRequest req)
        {
            Gamestate gamestate;

            if (req.Bid.Suit == BiddingSuit.Pass)
            {
                gamestate = BiddingService.Pass(req.Gamestate);
            }
            else
            {
                gamestate = BiddingService.Bid(req.Gamestate, req.Bid);
            }

            return gamestate;
        }

        [HttpPost]
        [Route("GetHighestBid")]
        public Bid GetHighestBid(Gamestate gamestate)
        {
            return gamestate.HighestBid;
        }
    }
}