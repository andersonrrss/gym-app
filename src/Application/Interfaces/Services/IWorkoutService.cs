using GymApp.Application.DTOs;
using GymApp.Domain.Common;

namespace GymApp.Application.Interfaces;

public interface IWorkoutService
{
    Task<Result<WorkoutResponseDTO>> GetWorkoutAsync(Guid workoutId, Guid requesterId);

    Task<Result<WorkoutResponseDTO>> CreateWorkoutAsync(WorkoutRequestDTO workoutDto, Guid requesterId);
}
