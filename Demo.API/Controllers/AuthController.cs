using Demo.API.Forms;
using Demo.API.Infrastructure;
using Demo.DAL.Entities;
using Demo.DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(UserRepository userRepository, TokenManager tokenManager) : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginForm form)
        {
            User? user = userRepository.GetByUsername(form.Username);
            if (user == null)
            {
                return Unauthorized();
            }
            if(user.Password != form.Password)
            {
                return Unauthorized();
            }

            return Ok(new { Token = tokenManager.CreateToken(user.Id, user.Username) });
        } 
    }
}
