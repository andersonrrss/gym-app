using GymApp.API.Extensions;
using GymApp.Application.Interfaces;
using GymApp.Application.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.API.Controllers
{
    [Route("api/user")]
    [ApiController]
    [Authorize]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IRoutineService _routineService;

        public UserController(IUserService userService, IRoutineService routineService)
        {
            _userService = userService;
            _routineService = routineService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserInformation()
        {
            var userId = User.GetUserId();
            var result = await _userService.GetUserInformationAsync(userId);
            return Respond(result);
        }

        [HttpGet("routines")]
        public async Task<IActionResult> GetUserRoutines()
        {
            var userId = User.GetUserId();
            var result = await _routineService.GetUserRoutinesAsync(userId);
            return Respond(result);
        }
    }
}
