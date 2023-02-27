using Microsoft.AspNetCore.Mvc;
using Redoublet.Backend.Models;
using Redoublet.Backend.Services;


namespace Redoublet.Backend.Controllers
{
    [ApiController]
    [Route("api")]
    public class BridgeGameLogic : ControllerBase
    {
        private readonly ILogger<BridgeGameLogic> _logger;

        public BridgeGameLogic(ILogger<BridgeGameLogic> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("StartGame")]
        public Gamestate StartGame(string Name1, string Name2, string Name3, string Name4)
        {
            // Initiate the game
            Gamestate gamestate = new Gamestate();

            // Divide the cards
            Player[] players =
            {
                new Player()
                {
                    Name = Name1,
                },
                new Player()
                {
                    Name = Name2,
                },
                new Player()
                {
                    Name = Name3,
                },
                new Player()
                {
                    Name = Name4,
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