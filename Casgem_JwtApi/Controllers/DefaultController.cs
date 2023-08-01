using Casgem_JwtApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_JwtApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[Action]")]
        public IActionResult Login()
        {
            return Created("",new BuildToken().CreateToken());
        }

        [HttpGet("[Action]")]
        [Authorize]
        public IActionResult ListCustomer()
        {
            return Ok("Müşteri listesine eriştiniz.");
        }
    }
}
