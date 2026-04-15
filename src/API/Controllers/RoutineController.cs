using GymApp.API.Extensions;
using GymApp.Application.DTOs;
using GymApp.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.API.Controllers
{
    [Route("api/routine")]
    [ApiController]
    [Authorize]
    public class RoutineController : BaseController
    {
        private readonly IRoutineService _routineService;

        public RoutineController(IRoutineService routineService)
        {
            _routineService = routineService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoutine([FromRoute] Guid id)
        {
            var userId = User.GetUserId();
            var result = await _routineService.GetRoutineAsync(id, userId);
            return Respond(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoutine([FromBody] RoutineRequestDTO routineDTO)
        {
            var userId = User.GetUserId();
            var result = await _routineService.CreateRoutineAsync(routineDTO, userId);
            return Respond(result, true);
        }
    }
}
