using Microsoft.AspNetCore.Mvc;
using Redoublet.Backend.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Redoublet_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BridgeGameLogic : ControllerBase
    {
        private readonly ILogger<BridgeGameLogic> _logger;

        public BridgeGameLogic(ILogger<BridgeGameLogic> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetTestJson")]
        public string Get()
        {
            GameData gameData = new GameData();

            Player[] players =
            {
                new Player()
                {
                    Name = "Pitcher",
                    Cards = new List<Card>()
                    {
                        new Card()
                        {
                            Value = 3,
                            Face = Face.Heart,
                        }
                    }
                }
            };

            gameData.Players = players;
            gameData.Dealer = Side.North;
            gameData.Round = 3;
            gameData.Trump = Face.Club;

            return HelperFunctions.ParseGameData(gameData);
        }

        [HttpPost]
        [Route("Test")]
        public string StartGame(string jsonGameStateString)
        {
            GameData gameData = HelperFunctions.ParseJson(jsonGameStateString);

            return gameData.Dealer.ToString();
        }
    }


    public static class HelperFunctions
    {
        // Method to parse GameData object into json
        public static GameData ParseJson(string jsonString)
        {
            GameData gameData = JsonSerializer.Deserialize<GameData>(jsonString);

            return gameData;
        }

        // Method to parse json object into GameData
        public static string ParseGameData(GameData gameData)
        {
            string json = JsonSerializer.Serialize(gameData);

            return json;
        }
    }
}