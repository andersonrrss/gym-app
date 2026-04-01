using GymApp.API.Extensions;
using GymApp.Application;
using GymApp.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserInformation([FromRoute] Guid id)
        {
            var requesterId = User.GetUserId();
            var result = await _userService.GetUserInformationAsync(id, requesterId);
            return Respond(result);
        }

        [HttpGet("{id}/routines")]
        public async Task<IActionResult> GetUserRoutines([FromRoute] Guid id)
        {
            var requesterId = User.GetUserId();
            var result = await _routineService.GetUserRoutinesAsync(id, requesterId);
            return Respond(result);
        }
    }
}
