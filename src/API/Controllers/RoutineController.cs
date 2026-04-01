using GymApp.API.Extensions;
using GymApp.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/routine")]
    [ApiController]
    [Authorize]
    public class RoutineController : ControllerBase
    {
        private readonly IRoutineService _routineService;

        public RoutineController(IRoutineService routineService)
        {
            _routineService = routineService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoutineInformation([FromRoute] Guid id)
        {
            var userId = User.GetUserId();
            var result = await _routineService.GetRoutineAsync(id, userId);
            return result.ToActionResult(this);
        }

        [HttpPost]
        public async Task<IActionResult> NewRoutine([FromBody] RoutineRequestDTO routineDTO)
        {
            var userId = User.GetUserId();
            var result = await _routineService.CreateRoutineAsync(routineDTO, userId);
            return result.ToActionResult(this);
        }
    }
}
