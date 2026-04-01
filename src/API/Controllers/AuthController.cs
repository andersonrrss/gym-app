using Microsoft.AspNetCore.Mvc;

using GymApp.Application.Interfaces;
using GymApp.Application.DTOs;

using MyApp.Namespace;

namespace GymApp.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : BaseController
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        
        // Registro
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO registerDTO)
        {
            var result = await _authService.TryRegisterUserAsync(registerDTO);

            return Respond(result);
        }

        // Login
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
        {
            var result = await _authService.TryLoginUserAsync(loginDTO);

            return Respond(result);
        }
    }
}
