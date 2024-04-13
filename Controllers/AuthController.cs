using Microsoft.AspNetCore.Mvc;
using ApiAquiTemBarbearia.Application.Services;

namespace ApiAquiTemBarbearia.Controllers
{
    [ApiController]
    [Route("api")]
    public class AuthController : Controller
    {
        [HttpPost("login")]
        public IActionResult Auth(string username, string password)
        {
            if (username == "filipe" && password == "123456")
            {
                var token = TokenService.GenerateToken(new Domain.Model.EmployeeAggregate.Employee());
                return Ok(token);
            }

            return BadRequest("username or password invalid");
        }

        [HttpPost("register")]
        public IActionResult Register(string username, string password)
        {
            return Ok("token");

        }
    }
}
