using Redoublet.Backend.Models;
using System.Text.Json;

namespace Redoublet.Backend.Services
{
    public class ConvertService
    {
        // Method to parse Gamestate object into json
        public static Gamestate ParseJson(string jsonString)
        {
            Gamestate gameData = JsonSerializer.Deserialize<Gamestate>(jsonString);

            return gameData;
        }

        // Method to parse json object into Gamestate
        public static string ParseGamestate(Gamestate gameData)
        {
            string json = JsonSerializer.Serialize(gameData);

            return json;
        }
    }
}
