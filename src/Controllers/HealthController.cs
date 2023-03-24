using Microsoft.AspNetCore.Mvc;

namespace src.Controllers{

    public class HealthController : ControllerBase
    {


        [Route("healthz")]
        public IActionResult healthz()
        {
            return Ok();
        }   
    }
}