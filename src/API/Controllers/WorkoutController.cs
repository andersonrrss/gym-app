using GymApp.API.Extensions;
using GymApp.Application.DTOs;
using GymApp.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GymApp.API.Controllers
{
    [Route("api/workouts")]
    [ApiController]
    [Authorize]
    public class WorkoutController : BaseController
    {
        private readonly IWorkoutService _workoutService;
        private readonly IWorkoutExerciseService _workoutExerciseService;

        public WorkoutController(IWorkoutService workoutService, IWorkoutExerciseService workoutExerciseService)
        {
            _workoutService = workoutService;
            _workoutExerciseService = workoutExerciseService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ViewWorkout([FromRoute] Guid id)
        {
            var userId = User.GetUserId();
            var result = await _workoutService.GetWorkoutAsync(id, userId);
            
            return Respond(result);
        }

        [HttpPost("{workoutId}/exercises")]
        public async Task<IActionResult> AddWorkoutExercise(
            [FromRoute] Guid workoutId, 
            [FromBody] WorkoutExerciseRequestDTO workoutExercise)
        {
            var userId = User.GetUserId();
            var result = await _workoutExerciseService.CreateWorkoutExerciseAsync(workoutId ,workoutExercise, userId);
            return Respond(result, true);
        }

        [HttpPost]
        public async Task<IActionResult> CreateWorkout([FromBody] WorkoutRequestDTO workoutDto)
        {
            var userId = User.GetUserId();
            var result = await _workoutService.CreateWorkoutAsync(workoutDto, userId);
            
            return Respond(result, true);
        }
    }
}
