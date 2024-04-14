using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ApiAquiTemBarbearia.Application.ViewModel;
using ApiAquiTemBarbearia.Domain.DTOs;

namespace ApiAquiTemBarbearia.Controllers.v1
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {

            return Ok("user");
        }
    }
}
