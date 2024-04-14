using ApiAquiTemBarbearia.Domain.Model.UserAggregate;
using ApiAquiTemBarbearia.Infraestrutura.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiAquiTemBarbearia.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : Controller
    {
        private readonly UserRepository _userRepository;
        public AuthController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("login")]
        public IActionResult Auth(string username, string password)
        {
            return BadRequest("username or password invalid");
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            // _userRepository.Add(user);
            return Ok(user);
        }
    }
}
