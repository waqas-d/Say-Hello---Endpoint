using Microsoft.AspNetCore.Mvc;

namespace Say_Hello___Endpoint.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class SayHelloEndpointController : ControllerBase
    {
        [HttpGet]
        [Route("GetHello/{usersName}")]

        public string GetHello(string usersName) {
            return "Hello, " + usersName;
        }

    }
