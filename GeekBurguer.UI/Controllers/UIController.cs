using GeekBurguer.UI.Contracts.Commands.Input;
using GeekBurguer.UI.Contracts.Commands.Output;
using Microsoft.AspNetCore.Mvc;

namespace GeekBurguer.UI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UIController : ControllerBase
    {

        private readonly ILogger<UIController> _logger;

        public UIController(ILogger<UIController> logger)
        {
            _logger = logger;
        }

        [HttpPost("api/face")]
        [ProducesResponseType(typeof(OutputFaceCommand), StatusCodes.Status200OK)]
        public IActionResult Face([FromBody] InputFaceCommand inputFace)
        {
            return Ok(new OutputFaceCommand()
            {
                Processing = true,
                UserId = 1111
            });
        }

        [HttpPost("api/foodRestrictions")]
        [ProducesResponseType(typeof(OutputFoodRestrictionsCommand), StatusCodes.Status200OK)]
        public IActionResult FoodRestrictions([FromBody] InputFoodRestrictionsCommand inputFoodRestrictions)
        {
            return Ok(new OutputFoodRestrictionsCommand() 
            {
                Processing = false,
                UserId = 1111
            });
        }

        [HttpPost("api/order")]
        [ProducesResponseType(typeof(OutputOrderCommand), StatusCodes.Status200OK)]
        public IActionResult Order([FromBody] InputOrderCommand inputOrder)
        {
            return Ok(new OutputOrderCommand() 
            {
                OrderId = 1111,
                StoreName = "Oficina Cismas",
                Total = "10.20"
            });
        }
    }
}