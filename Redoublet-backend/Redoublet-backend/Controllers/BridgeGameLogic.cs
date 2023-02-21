using Microsoft.AspNetCore.Mvc;

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
        [Route("/GetCard")]
        public string Get()
        {
            return "Harten 4";
        }
    }
}