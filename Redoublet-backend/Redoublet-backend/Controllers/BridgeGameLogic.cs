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
            Gamestate gamestate = new Gamestate();

            // Divide the cards
            Player[] players =
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
            };

            gamestate.Players = players;

            gamestate.Dealer = Side.North;
            gamestate.CurrentPlayer = Side.North;
            gamestate.Round = 0;

            gamestate = GameService.DealCards(gamestate);

            gamestate.Tricks = new List<Trick>() { new Trick() };

            return gamestate;
        }

        [HttpPost]
        [Route("PlayCard")]
        public Gamestate PlayCard(Gamestate gamestate, [FromQuery]Card card)
        {
            // Get the latest trick
            Trick currentTrick = gamestate.Tricks.Last();

            // Add the given card to the trick
            currentTrick.Cards[(int) gamestate.CurrentPlayer] = card;

            // Decide the next player
            int currentPlayer = (int) gamestate.CurrentPlayer;
            int nextPlayer = (currentPlayer + 1) % 4;

            gamestate.CurrentPlayer = (Side)nextPlayer;

            return gamestate;
        }
    }
}