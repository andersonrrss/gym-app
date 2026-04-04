using GymApp.API.Extensions;
using GymApp.Application;
using GymApp.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/workout")]
    [ApiController]
    public class WorkoutController : BaseController
    {
        private readonly IWorkoutService _workoutService;

        public WorkoutController(IWorkoutService workoutService)
        {
            _workoutService = workoutService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ViewWorkout([FromRoute] Guid id)
        {
            var userId = User.GetUserId();
            var result = await _workoutService.GetWorkoutAsync(id, userId);
            
            return Respond(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewWorkout([FromBody] WorkoutRequestDTO workoutDto)
        {
            var userId = User.GetUserId();
            var result = await _workoutService.CreateWorkoutAsync(workoutDto, userId);
            
            return Respond(result);
        }
    }
}
