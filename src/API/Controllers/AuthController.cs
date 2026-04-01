using Microsoft.AspNetCore.Mvc;

using GymApp.Application.Interfaces;
using GymApp.Application.DTOs;

using GymApp.API.Extensions;
using System.Runtime.CompilerServices;

namespace GymApp.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
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

            return result.ToActionResult(this);
        }

        // Login
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
        {
            var result = await _authService.TryLoginUserAsync(loginDTO);

            return result.ToActionResult(this);
        }
    }
}
